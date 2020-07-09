using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Keyword_Diff {
	public partial class MainForm: Form {
		private const char TARGET_DELIMITER = '|';
		private static readonly char[] Delimiters = { '|', '\t', ' ' };
		private static readonly char[] DelimitersIncludingNewlines = { '|', '\t', ' ', '\r', '\n' };

		private StringBuilder _intersectionBuilder;
		private StringBuilder _aMinusBBuilder;
		private StringBuilder _bMinusABuilder;

		public MainForm() {
			InitializeComponent();
			AdditionallyInitializeComponent();
		}

		private void AdditionallyInitializeComponent() {
			var menuItemA = new MenuItem {
				Text = "pipes to newlines",
				Tag = textBoxA
			};
			var menuItemB = new MenuItem {
				Text = "pipes to newlines",
				Tag = textBoxB
			};

			menuItemA.Click += PipesToNewlines_Click;
			menuItemB.Click += PipesToNewlines_Click;

			var contextMenuA = new ContextMenu();
			contextMenuA.MenuItems.Add(menuItemA);
			var contextMenuB = new ContextMenu();
			contextMenuB.MenuItems.Add(menuItemB);

			textBoxA.ContextMenu = contextMenuA;
			textBoxB.ContextMenu = contextMenuB;
		}

		private void Diff() {
			var leftLines = textBoxA.Lines;
			var rightLines = textBoxB.Lines;
			if (leftLines.Length > 0 && rightLines.Length > 0) {
				var numberOfLinesDoMatch = (leftLines.Length == rightLines.Length);
				if (checkBoxForceDiff.Checked || numberOfLinesDoMatch) {
					var tombstoneIndex = -1;

					_intersectionBuilder = new StringBuilder();
					_aMinusBBuilder = new StringBuilder();
					_bMinusABuilder = new StringBuilder();

					var numberOfLines = leftLines.Length;
					for (var i = 0; i < numberOfLines; i++) {
						try {
							var leftLine = leftLines[i];
							var rightLine = rightLines[i];

							DiffLine(leftLine, rightLine);
						} catch (IndexOutOfRangeException) {
							numberOfLinesDoMatch = false;
							break;
						}

						tombstoneIndex = i;
					}

					// TODO: textbox word wrap to false

					richTextBoxResultAMinusB.Text = _aMinusBBuilder.ToString();
					richTextBoxIntersection.Text = _intersectionBuilder.ToString();
					richTextBoxResultBMinusA.Text = _bMinusABuilder.ToString();

					toolStripStatusLabel.Text = (numberOfLinesDoMatch? String.Empty: $"Operation halted right after index of {tombstoneIndex}");
				} else {
					richTextBoxResultAMinusB.Text = String.Empty;
					richTextBoxIntersection.Text = String.Empty;
					richTextBoxResultBMinusA.Text = String.Empty;

					toolStripStatusLabel.Text = $"left and right aren't of the same number of lines!\n{leftLines.Length} vs {rightLines.Length}";
				}
			}
		}

		private void DiffLine(string leftLine, string rightLine) {
			IEnumerable<string> leftKeywords = leftLine.Trim().Split(Delimiters, StringSplitOptions.RemoveEmptyEntries);
			IEnumerable<string> rightKeywords = rightLine.Trim().Split(Delimiters, StringSplitOptions.RemoveEmptyEntries);

			_aMinusBBuilder.AppendLine(AMinusB(leftKeywords, rightKeywords));
			_intersectionBuilder.AppendLine(Intersect(leftKeywords, rightKeywords));
			_bMinusABuilder.AppendLine(BMinusA(leftKeywords, rightKeywords));
		}

		private void TextBoxInput_TextChanged(object sender, EventArgs e) {
			Diff();
		}
		private void CheckBoxForceDiff_CheckedChanged(object sender, EventArgs e) {
			Diff();
		}
		private void TextBox_KeyDown(object sender, KeyEventArgs e) {
			if (sender is TextBox textBox) {
				if (e.KeyData == (Keys.Control | Keys.A)) {
					textBox.SelectAll();
				}
			}
		}
		private void ButtonMerge_Click(object sender, EventArgs e) {
			if (sender == buttonMergeA) {
				IEnumerable<string> delimitedKeywords = textBoxA.Text.Split(DelimitersIncludingNewlines, StringSplitOptions.RemoveEmptyEntries);
				textBoxA.Text =
					new HashSet<string>(delimitedKeywords)
						.OrderBy(element => element)
						.FlattenToString(TARGET_DELIMITER);
			} else if (sender == buttonMergeB) {
				IEnumerable<string> delimitedKeywords = textBoxB.Text.Split(DelimitersIncludingNewlines, StringSplitOptions.RemoveEmptyEntries);
				textBoxB.Text =
					new HashSet<string>(delimitedKeywords)
						.OrderBy(element => element)
						.FlattenToString(TARGET_DELIMITER);
			} else {
				MessageBox.Show(null, "You must have registered a wrong EventHandler.", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void PipesToNewlines_Click(object sender, EventArgs e) {
			if (sender is MenuItem menuItem) {
				if (menuItem.Tag == textBoxA) {
					textBoxA.Text = DelimitersToNewlines(textBoxA.Text);
				} else if (menuItem.Tag == textBoxB) {
					textBoxB.Text = DelimitersToNewlines(textBoxB.Text);
				}
			}
		}

		private static string Intersect(IEnumerable<string> leftKeywords, IEnumerable<string> rightKeywords) {
			var intersection = new HashSet<string>(leftKeywords);
			intersection.IntersectWith(rightKeywords);

			return intersection
				.OrderBy(element => element)
				.FlattenToString(TARGET_DELIMITER);
		}
		private static string AMinusB(IEnumerable<string> leftKeywords, IEnumerable<string> rightKeywords) {
			var merged = new HashSet<string>(leftKeywords);
			merged.ExceptWith(rightKeywords);

			return merged
				.OrderBy(element => element)
				.FlattenToString(TARGET_DELIMITER);
		}
		private static string BMinusA(IEnumerable<string> leftKeywords, IEnumerable<string> rightKeywords) {
			var merged = new HashSet<string>(rightKeywords);
			merged.ExceptWith(leftKeywords);

			return merged
				.OrderBy(element => element)
				.FlattenToString(TARGET_DELIMITER);
		}

		private static string DelimitersToNewlines(string source) {
			var regexBuilder = new StringBuilder("[");
			foreach (var delimiter in DelimitersIncludingNewlines) {
				regexBuilder.Append(@"\").Append(delimiter);
			}

			regexBuilder.Append("]");

			return Regex.Replace(source, regexBuilder.ToString(), Environment.NewLine);
		}
	}
}