using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Keyword_Diff {
	public partial class MainForm: Form {
		private const char TARGET_DELIMITER = '|';
		private static readonly char[] delimiters = { '|', '\t', ' ' };
		private static readonly char[] delimitersIncludingNewlines = { '|', '\t', ' ', '\r', '\n' };

		private StringBuilder intersectionBuilder;
		private StringBuilder aMinusBBuilder;
		private StringBuilder bMinusABuilder;

		public MainForm() {
			InitializeComponent();
			AdditionallyInitializeComponent();
		}

		private void AdditionallyInitializeComponent() {
			MenuItem menuItemA = new MenuItem { 
				Text = "pipes to newlines",
				Tag = textBoxA
			};
			MenuItem menuItemB = new MenuItem { 
				Text = "pipes to newlines",
				Tag = textBoxB
			};

			menuItemA.Click += PipesToNewlines_Click;
			menuItemB.Click += PipesToNewlines_Click;

			ContextMenu contextMenuA = new ContextMenu();
			contextMenuA.MenuItems.Add(menuItemA);
			ContextMenu contextMenuB = new ContextMenu();
			contextMenuB.MenuItems.Add(menuItemB);

			textBoxA.ContextMenu = contextMenuA;
			textBoxB.ContextMenu = contextMenuB;
		}

		private void Diff() {
			string[] leftLines = textBoxA.Lines;
			string[] rightLines = textBoxB.Lines;
			if (leftLines.Length > 0 && rightLines.Length > 0) {
				bool numberOfLinesDoMatch = (leftLines.Length == rightLines.Length);
				if (checkBoxForceDiff.Checked || numberOfLinesDoMatch) {
					int tombstoneIndex = -1;

					intersectionBuilder = new StringBuilder();
					aMinusBBuilder = new StringBuilder();
					bMinusABuilder = new StringBuilder();

					int numberOfLines = leftLines.Length;
					for (int i = 0; i < numberOfLines; i++) {
						try {
							string leftLine = leftLines[i];
							string rightLine = rightLines[i];

							DiffLine(leftLine, rightLine);
						} catch (IndexOutOfRangeException) {
							numberOfLinesDoMatch = false;
							break;
						}

						tombstoneIndex = i;
					}

					// TODO: textbox word wrap to false

					richTextBoxResultAMinusB.Text = aMinusBBuilder.ToString();
					richTextBoxIntersection.Text = intersectionBuilder.ToString();
					richTextBoxResultBMinusA.Text = bMinusABuilder.ToString();

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
			IEnumerable<string> leftKeywords = leftLine.Trim().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
			IEnumerable<string> rightKeywords = rightLine.Trim().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

			aMinusBBuilder.AppendLine(AMinusB(leftKeywords, rightKeywords));
			intersectionBuilder.AppendLine(Intersect(leftKeywords, rightKeywords));
			bMinusABuilder.AppendLine(BMinusA(leftKeywords, rightKeywords));
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
				IEnumerable<string> delimitedKeywords = textBoxA.Text.Split(delimitersIncludingNewlines, StringSplitOptions.RemoveEmptyEntries);
				textBoxA.Text =
					new HashSet<string>(delimitedKeywords)
						.OrderBy(element => element)
						.FlattenToString(TARGET_DELIMITER);
			} else if (sender == buttonMergeB) {
				IEnumerable<string> delimitedKeywords = textBoxB.Text.Split(delimitersIncludingNewlines, StringSplitOptions.RemoveEmptyEntries);
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
			HashSet<string> intersection = new HashSet<string>(leftKeywords);
			intersection.IntersectWith(rightKeywords);

			return intersection
				.OrderBy(element => element)
				.FlattenToString(TARGET_DELIMITER);
		}
		private static string AMinusB(IEnumerable<string> leftKeywords, IEnumerable<string> rightKeywords) {
			HashSet<string> merged = new HashSet<string>(leftKeywords);
			merged.ExceptWith(rightKeywords);

			return merged
				.OrderBy(element => element)
				.FlattenToString(TARGET_DELIMITER);
		}
		private static string BMinusA(IEnumerable<string> leftKeywords, IEnumerable<string> rightKeywords) {
			HashSet<string> merged = new HashSet<string>(rightKeywords);
			merged.ExceptWith(leftKeywords);

			return merged
				.OrderBy(element => element)
				.FlattenToString(TARGET_DELIMITER);
		}

		private static string DelimitersToNewlines(string source) {
			StringBuilder regexBuilder = new StringBuilder("[");
			foreach (char delimiter in delimitersIncludingNewlines) {
				regexBuilder.Append(@"\").Append(delimiter);
			}

			regexBuilder.Append("]");

			return Regex.Replace(source, regexBuilder.ToString(), Environment.NewLine);
		}
	}
}