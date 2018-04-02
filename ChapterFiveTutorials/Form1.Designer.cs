namespace ChapterFiveTutorials
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
            this.startingBlanceLabel = new System.Windows.Forms.Label();
            this.numberOfMonthsLabel = new System.Windows.Forms.Label();
            this.endingBalnceLabel = new System.Windows.Forms.Label();
            this.endingBalnceOutputLabel = new System.Windows.Forms.Label();
            this.numberOfMonthsTextBox = new System.Windows.Forms.TextBox();
            this.startingBalncetextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startingBlanceLabel
            // 
            this.startingBlanceLabel.AutoSize = true;
            this.startingBlanceLabel.Location = new System.Drawing.Point(47, 35);
            this.startingBlanceLabel.Name = "startingBlanceLabel";
            this.startingBlanceLabel.Size = new System.Drawing.Size(88, 13);
            this.startingBlanceLabel.TabIndex = 0;
            this.startingBlanceLabel.Text = "Starting Balance:";
            // 
            // numberOfMonthsLabel
            // 
            this.numberOfMonthsLabel.AutoSize = true;
            this.numberOfMonthsLabel.Location = new System.Drawing.Point(39, 78);
            this.numberOfMonthsLabel.Name = "numberOfMonthsLabel";
            this.numberOfMonthsLabel.Size = new System.Drawing.Size(97, 13);
            this.numberOfMonthsLabel.TabIndex = 1;
            this.numberOfMonthsLabel.Text = "Number of Months:";
            // 
            // endingBalnceLabel
            // 
            this.endingBalnceLabel.AutoSize = true;
            this.endingBalnceLabel.Location = new System.Drawing.Point(51, 150);
            this.endingBalnceLabel.Name = "endingBalnceLabel";
            this.endingBalnceLabel.Size = new System.Drawing.Size(85, 13);
            this.endingBalnceLabel.TabIndex = 2;
            this.endingBalnceLabel.Text = "Ending Balance:";
            // 
            // endingBalnceOutputLabel
            // 
            this.endingBalnceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endingBalnceOutputLabel.Location = new System.Drawing.Point(141, 123);
            this.endingBalnceOutputLabel.Name = "endingBalnceOutputLabel";
            this.endingBalnceOutputLabel.Size = new System.Drawing.Size(141, 40);
            this.endingBalnceOutputLabel.TabIndex = 3;
            this.endingBalnceOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endingBalnceOutputLabel.Click += new System.EventHandler(this.endingBalnceOutputLabel_Click);
            // 
            // numberOfMonthsTextBox
            // 
            this.numberOfMonthsTextBox.Location = new System.Drawing.Point(142, 71);
            this.numberOfMonthsTextBox.Name = "numberOfMonthsTextBox";
            this.numberOfMonthsTextBox.Size = new System.Drawing.Size(140, 20);
            this.numberOfMonthsTextBox.TabIndex = 4;
            // 
            // startingBalncetextBox
            // 
            this.startingBalncetextBox.Location = new System.Drawing.Point(141, 32);
            this.startingBalncetextBox.Name = "startingBalncetextBox";
            this.startingBalncetextBox.Size = new System.Drawing.Size(141, 20);
            this.startingBalncetextBox.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(239, 238);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(130, 238);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 238);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 273);
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
            this.Text = "Ending Balance:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startingBlanceLabel;
        private System.Windows.Forms.Label numberOfMonthsLabel;
        private System.Windows.Forms.Label endingBalnceLabel;
        private System.Windows.Forms.Label endingBalnceOutputLabel;
        private System.Windows.Forms.TextBox numberOfMonthsTextBox;
        private System.Windows.Forms.TextBox startingBalncetextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
    }
}

