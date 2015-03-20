namespace unicode_csv_converter
{
    partial class ConverterForm
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.browseFilesButton = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.delimiterLabel = new System.Windows.Forms.Label();
            this.encodingSelection = new System.Windows.Forms.ComboBox();
            this.doConvertButton = new System.Windows.Forms.Button();
            this.delimiterTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.AllowDrop = true;
            this.inputTextBox.Location = new System.Drawing.Point(12, 28);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(182, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.inputTextBox_DragDrop);
            this.inputTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.inputTextBox_DragEnter);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 93);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(182, 20);
            this.outputTextBox.TabIndex = 1;
            // 
            // browseFilesButton
            // 
            this.browseFilesButton.Location = new System.Drawing.Point(119, 53);
            this.browseFilesButton.Name = "browseFilesButton";
            this.browseFilesButton.Size = new System.Drawing.Size(75, 23);
            this.browseFilesButton.TabIndex = 2;
            this.browseFilesButton.Text = "Browse...";
            this.browseFilesButton.UseVisualStyleBackColor = true;
            this.browseFilesButton.Click += new System.EventHandler(this.browseFilesButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(9, 12);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(31, 13);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Input";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(9, 77);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(39, 13);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Output";
            // 
            // delimiterLabel
            // 
            this.delimiterLabel.AutoSize = true;
            this.delimiterLabel.Location = new System.Drawing.Point(9, 125);
            this.delimiterLabel.Name = "delimiterLabel";
            this.delimiterLabel.Size = new System.Drawing.Size(47, 13);
            this.delimiterLabel.TabIndex = 6;
            this.delimiterLabel.Text = "Delimiter";
            // 
            // encodingSelection
            // 
            this.encodingSelection.FormattingEnabled = true;
            this.encodingSelection.Location = new System.Drawing.Point(12, 177);
            this.encodingSelection.Name = "encodingSelection";
            this.encodingSelection.Size = new System.Drawing.Size(75, 21);
            this.encodingSelection.TabIndex = 7;
            // 
            // doConvertButton
            // 
            this.doConvertButton.Location = new System.Drawing.Point(12, 220);
            this.doConvertButton.Name = "doConvertButton";
            this.doConvertButton.Size = new System.Drawing.Size(75, 23);
            this.doConvertButton.TabIndex = 8;
            this.doConvertButton.Text = "Convert!";
            this.doConvertButton.UseVisualStyleBackColor = true;
            this.doConvertButton.Click += new System.EventHandler(this.doConvertButton_Click);
            // 
            // delimiterTextBox
            // 
            this.delimiterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::unicode_csv_converter.Properties.Settings.Default, "Delimiter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.delimiterTextBox.Location = new System.Drawing.Point(12, 141);
            this.delimiterTextBox.MaxLength = 10;
            this.delimiterTextBox.Name = "delimiterTextBox";
            this.delimiterTextBox.Size = new System.Drawing.Size(47, 20);
            this.delimiterTextBox.TabIndex = 3;
            this.delimiterTextBox.Text = global::unicode_csv_converter.Properties.Settings.Default.Delimiter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 255);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(242, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressLabel
            // 
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 17);
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 277);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.doConvertButton);
            this.Controls.Add(this.encodingSelection);
            this.Controls.Add(this.delimiterLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.delimiterTextBox);
            this.Controls.Add(this.browseFilesButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "ConverterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Convert Excel to CSV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConverterForm_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button browseFilesButton;
        private System.Windows.Forms.TextBox delimiterTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label delimiterLabel;
        private System.Windows.Forms.ComboBox encodingSelection;
        private System.Windows.Forms.Button doConvertButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel progressLabel;
    }
}

