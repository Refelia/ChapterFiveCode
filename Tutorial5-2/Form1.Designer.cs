namespace Tutorial5_2
{
    partial class Form1
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.startingBalncetextBox = new System.Windows.Forms.TextBox();
            this.numberOfMonthsTextBox = new System.Windows.Forms.TextBox();
            this.endingBalnceOutputLabel = new System.Windows.Forms.Label();
            this.endingBalnceLabel = new System.Windows.Forms.Label();
            this.numberOfMonthsLabel = new System.Windows.Forms.Label();
            this.startingBlanceLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 277);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 17;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(121, 277);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(255, 277);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // startingBalncetextBox
            // 
            this.startingBalncetextBox.Location = new System.Drawing.Point(120, 16);
            this.startingBalncetextBox.Name = "startingBalncetextBox";
            this.startingBalncetextBox.Size = new System.Drawing.Size(159, 20);
            this.startingBalncetextBox.TabIndex = 14;
            // 
            // numberOfMonthsTextBox
            // 
            this.numberOfMonthsTextBox.Location = new System.Drawing.Point(121, 55);
            this.numberOfMonthsTextBox.Name = "numberOfMonthsTextBox";
            this.numberOfMonthsTextBox.Size = new System.Drawing.Size(158, 20);
            this.numberOfMonthsTextBox.TabIndex = 13;
            // 
            // endingBalnceOutputLabel
            // 
            this.endingBalnceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endingBalnceOutputLabel.Location = new System.Drawing.Point(138, 215);
            this.endingBalnceOutputLabel.Name = "endingBalnceOutputLabel";
            this.endingBalnceOutputLabel.Size = new System.Drawing.Size(141, 26);
            this.endingBalnceOutputLabel.TabIndex = 12;
            this.endingBalnceOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingBalnceLabel
            // 
            this.endingBalnceLabel.AutoSize = true;
            this.endingBalnceLabel.Location = new System.Drawing.Point(47, 228);
            this.endingBalnceLabel.Name = "endingBalnceLabel";
            this.endingBalnceLabel.Size = new System.Drawing.Size(85, 13);
            this.endingBalnceLabel.TabIndex = 11;
            this.endingBalnceLabel.Text = "Ending Balance:";
            // 
            // numberOfMonthsLabel
            // 
            this.numberOfMonthsLabel.AutoSize = true;
            this.numberOfMonthsLabel.Location = new System.Drawing.Point(18, 62);
            this.numberOfMonthsLabel.Name = "numberOfMonthsLabel";
            this.numberOfMonthsLabel.Size = new System.Drawing.Size(97, 13);
            this.numberOfMonthsLabel.TabIndex = 10;
            this.numberOfMonthsLabel.Text = "Number of Months:";
            // 
            // startingBlanceLabel
            // 
            this.startingBlanceLabel.AutoSize = true;
            this.startingBlanceLabel.Location = new System.Drawing.Point(26, 19);
            this.startingBlanceLabel.Name = "startingBlanceLabel";
            this.startingBlanceLabel.Size = new System.Drawing.Size(88, 13);
            this.startingBlanceLabel.TabIndex = 9;
            this.startingBlanceLabel.Text = "Starting Balance:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "detailListBox"});
            this.listBox1.Location = new System.Drawing.Point(50, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 95);
            this.listBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 312);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startingBalncetextBox);
            this.Controls.Add(this.numberOfMonthsTextBox);
            this.Controls.Add(this.endingBalnceOutputLabel);
            this.Controls.Add(this.endingBalnceLabel);
            this.Controls.Add(this.numberOfMonthsLabel);
            this.Controls.Add(this.startingBlanceLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox startingBalncetextBox;
        private System.Windows.Forms.TextBox numberOfMonthsTextBox;
        private System.Windows.Forms.Label endingBalnceOutputLabel;
        private System.Windows.Forms.Label endingBalnceLabel;
        private System.Windows.Forms.Label numberOfMonthsLabel;
        private System.Windows.Forms.Label startingBlanceLabel;
        private System.Windows.Forms.ListBox listBox1;
    }
}

