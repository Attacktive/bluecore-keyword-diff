namespace Keyword_Diff
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBoxResultAMinusB = new System.Windows.Forms.RichTextBox();
			this.textBoxA = new System.Windows.Forms.TextBox();
			this.textBoxB = new System.Windows.Forms.TextBox();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.richTextBoxResultBMinusA = new System.Windows.Forms.RichTextBox();
			this.labelA = new System.Windows.Forms.Label();
			this.labelB = new System.Windows.Forms.Label();
			this.labelAMinusB = new System.Windows.Forms.Label();
			this.labelBMinusA = new System.Windows.Forms.Label();
			this.richTextBoxIntersection = new System.Windows.Forms.RichTextBox();
			this.checkBoxForceDiff = new System.Windows.Forms.CheckBox();
			this.buttonMergeA = new System.Windows.Forms.Button();
			this.labelAIntersectB = new System.Windows.Forms.Label();
			this.buttonMergeB = new System.Windows.Forms.Button();
			this.textBoxLeftLabel = new System.Windows.Forms.TextBox();
			this.textBoxRightLabel = new System.Windows.Forms.TextBox();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBoxResultAMinusB
			// 
			this.richTextBoxResultAMinusB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.richTextBoxResultAMinusB.Location = new System.Drawing.Point(13, 303);
			this.richTextBoxResultAMinusB.MaxLength = 6666666;
			this.richTextBoxResultAMinusB.MinimumSize = new System.Drawing.Size(50, 4);
			this.richTextBoxResultAMinusB.Name = "richTextBoxResultAMinusB";
			this.richTextBoxResultAMinusB.ReadOnly = true;
			this.richTextBoxResultAMinusB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
			this.richTextBoxResultAMinusB.Size = new System.Drawing.Size(350, 345);
			this.richTextBoxResultAMinusB.TabIndex = 2;
			this.richTextBoxResultAMinusB.Text = "";
			this.richTextBoxResultAMinusB.WordWrap = false;
			// 
			// textBoxA
			// 
			this.textBoxA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxA.Location = new System.Drawing.Point(13, 55);
			this.textBoxA.MaxLength = 6666666;
			this.textBoxA.MinimumSize = new System.Drawing.Size(50, 4);
			this.textBoxA.Multiline = true;
			this.textBoxA.Name = "textBoxA";
			this.textBoxA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxA.Size = new System.Drawing.Size(502, 224);
			this.textBoxA.TabIndex = 0;
			this.textBoxA.WordWrap = false;
			this.textBoxA.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
			this.textBoxA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
			// 
			// textBoxB
			// 
			this.textBoxB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxB.Location = new System.Drawing.Point(521, 55);
			this.textBoxB.MaxLength = 6666666;
			this.textBoxB.MinimumSize = new System.Drawing.Size(50, 4);
			this.textBoxB.Multiline = true;
			this.textBoxB.Name = "textBoxB";
			this.textBoxB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxB.Size = new System.Drawing.Size(502, 224);
			this.textBoxB.TabIndex = 1;
			this.textBoxB.WordWrap = false;
			this.textBoxB.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
			this.textBoxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
			// 
			// statusStrip
			// 
			this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 651);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(1035, 22);
			this.statusStrip.TabIndex = 5;
			this.statusStrip.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 16);
			// 
			// richTextBoxResultBMinusA
			// 
			this.richTextBoxResultBMinusA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxResultBMinusA.Location = new System.Drawing.Point(673, 303);
			this.richTextBoxResultBMinusA.MaxLength = 6666666;
			this.richTextBoxResultBMinusA.MinimumSize = new System.Drawing.Size(50, 4);
			this.richTextBoxResultBMinusA.Name = "richTextBoxResultBMinusA";
			this.richTextBoxResultBMinusA.ReadOnly = true;
			this.richTextBoxResultBMinusA.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
			this.richTextBoxResultBMinusA.Size = new System.Drawing.Size(350, 345);
			this.richTextBoxResultBMinusA.TabIndex = 4;
			this.richTextBoxResultBMinusA.Text = "";
			this.richTextBoxResultBMinusA.WordWrap = false;
			// 
			// labelA
			// 
			this.labelA.Location = new System.Drawing.Point(13, 24);
			this.labelA.Name = "labelA";
			this.labelA.Size = new System.Drawing.Size(17, 26);
			this.labelA.TabIndex = 7;
			this.labelA.Text = "A";
			this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelB
			// 
			this.labelB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelB.Location = new System.Drawing.Point(518, 21);
			this.labelB.Name = "labelB";
			this.labelB.Size = new System.Drawing.Size(17, 25);
			this.labelB.TabIndex = 8;
			this.labelB.Text = "B";
			this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelAMinusB
			// 
			this.labelAMinusB.AutoSize = true;
			this.labelAMinusB.Location = new System.Drawing.Point(13, 285);
			this.labelAMinusB.Name = "labelAMinusB";
			this.labelAMinusB.Size = new System.Drawing.Size(44, 15);
			this.labelAMinusB.TabIndex = 9;
			this.labelAMinusB.Text = "A - B";
			// 
			// labelBMinusA
			// 
			this.labelBMinusA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelBMinusA.AutoSize = true;
			this.labelBMinusA.Location = new System.Drawing.Point(670, 285);
			this.labelBMinusA.Name = "labelBMinusA";
			this.labelBMinusA.Size = new System.Drawing.Size(44, 15);
			this.labelBMinusA.TabIndex = 10;
			this.labelBMinusA.Text = "B - A";
			// 
			// richTextBoxIntersection
			// 
			this.richTextBoxIntersection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxIntersection.Location = new System.Drawing.Point(370, 303);
			this.richTextBoxIntersection.MaxLength = 6666666;
			this.richTextBoxIntersection.MinimumSize = new System.Drawing.Size(50, 4);
			this.richTextBoxIntersection.Name = "richTextBoxIntersection";
			this.richTextBoxIntersection.ReadOnly = true;
			this.richTextBoxIntersection.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
			this.richTextBoxIntersection.Size = new System.Drawing.Size(297, 345);
			this.richTextBoxIntersection.TabIndex = 3;
			this.richTextBoxIntersection.Text = "";
			this.richTextBoxIntersection.WordWrap = false;
			// 
			// checkBoxForceDiff
			// 
			this.checkBoxForceDiff.AutoSize = true;
			this.checkBoxForceDiff.Checked = true;
			this.checkBoxForceDiff.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxForceDiff.Location = new System.Drawing.Point(12, 2);
			this.checkBoxForceDiff.Name = "checkBoxForceDiff";
			this.checkBoxForceDiff.Size = new System.Drawing.Size(86, 19);
			this.checkBoxForceDiff.TabIndex = 6;
			this.checkBoxForceDiff.Text = "force diff";
			this.checkBoxForceDiff.UseVisualStyleBackColor = true;
			this.checkBoxForceDiff.CheckedChanged += new System.EventHandler(this.CheckBoxForceDiff_CheckedChanged);
			// 
			// buttonMergeA
			// 
			this.buttonMergeA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMergeA.Location = new System.Drawing.Point(439, 15);
			this.buttonMergeA.Name = "buttonMergeA";
			this.buttonMergeA.Size = new System.Drawing.Size(75, 34);
			this.buttonMergeA.TabIndex = 11;
			this.buttonMergeA.Text = "Merge A";
			this.buttonMergeA.UseVisualStyleBackColor = true;
			this.buttonMergeA.Click += new System.EventHandler(this.ButtonMerge_Click);
			// 
			// labelAIntersectB
			// 
			this.labelAIntersectB.AutoSize = true;
			this.labelAIntersectB.Location = new System.Drawing.Point(367, 285);
			this.labelAIntersectB.Name = "labelAIntersectB";
			this.labelAIntersectB.Size = new System.Drawing.Size(46, 15);
			this.labelAIntersectB.TabIndex = 10;
			this.labelAIntersectB.Text = "A ∩ B";
			// 
			// buttonMergeB
			// 
			this.buttonMergeB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMergeB.Location = new System.Drawing.Point(948, 16);
			this.buttonMergeB.Name = "buttonMergeB";
			this.buttonMergeB.Size = new System.Drawing.Size(75, 34);
			this.buttonMergeB.TabIndex = 11;
			this.buttonMergeB.Text = "Merge B";
			this.buttonMergeB.UseVisualStyleBackColor = true;
			this.buttonMergeB.Click += new System.EventHandler(this.ButtonMerge_Click);
			// 
			// textBoxLeftLabel
			// 
			this.textBoxLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxLeftLabel.Location = new System.Drawing.Point(36, 24);
			this.textBoxLeftLabel.Name = "textBoxLeftLabel";
			this.textBoxLeftLabel.Size = new System.Drawing.Size(333, 25);
			this.textBoxLeftLabel.TabIndex = 12;
			// 
			// textBoxRightLabel
			// 
			this.textBoxRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxRightLabel.Location = new System.Drawing.Point(541, 21);
			this.textBoxRightLabel.Name = "textBoxRightLabel";
			this.textBoxRightLabel.Size = new System.Drawing.Size(333, 25);
			this.textBoxRightLabel.TabIndex = 12;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1035, 673);
			this.Controls.Add(this.textBoxRightLabel);
			this.Controls.Add(this.textBoxLeftLabel);
			this.Controls.Add(this.buttonMergeB);
			this.Controls.Add(this.buttonMergeA);
			this.Controls.Add(this.checkBoxForceDiff);
			this.Controls.Add(this.richTextBoxIntersection);
			this.Controls.Add(this.labelB);
			this.Controls.Add(this.labelAIntersectB);
			this.Controls.Add(this.labelBMinusA);
			this.Controls.Add(this.labelAMinusB);
			this.Controls.Add(this.labelA);
			this.Controls.Add(this.richTextBoxResultBMinusA);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.textBoxB);
			this.Controls.Add(this.textBoxA);
			this.Controls.Add(this.richTextBoxResultAMinusB);
			this.MinimumSize = new System.Drawing.Size(888, 47);
			this.Name = "MainForm";
			this.Text = "Keyword Diff";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.RichTextBox richTextBoxResultAMinusB;
		private System.Windows.Forms.TextBox textBoxA;
		private System.Windows.Forms.TextBox textBoxB;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.RichTextBox richTextBoxResultBMinusA;
		private System.Windows.Forms.Label labelA;
		private System.Windows.Forms.Label labelB;
		private System.Windows.Forms.Label labelAMinusB;
		private System.Windows.Forms.Label labelBMinusA;
		private System.Windows.Forms.RichTextBox richTextBoxIntersection;
		private System.Windows.Forms.CheckBox checkBoxForceDiff;
		private System.Windows.Forms.Button buttonMergeA;
		private System.Windows.Forms.Label labelAIntersectB;
		private System.Windows.Forms.Button buttonMergeB;
		private System.Windows.Forms.TextBox textBoxLeftLabel;
		private System.Windows.Forms.TextBox textBoxRightLabel;
	}
}

