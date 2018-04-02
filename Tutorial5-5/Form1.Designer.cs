namespace Tutorial5_5
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
            this.friendsNameTextBox = new System.Windows.Forms.TextBox();
            this.friendsNameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.writeNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // friendsNameTextBox
            // 
            this.friendsNameTextBox.Location = new System.Drawing.Point(34, 35);
            this.friendsNameTextBox.Name = "friendsNameTextBox";
            this.friendsNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.friendsNameTextBox.TabIndex = 7;
            // 
            // friendsNameLabel
            // 
            this.friendsNameLabel.AutoSize = true;
            this.friendsNameLabel.Location = new System.Drawing.Point(31, 19);
            this.friendsNameLabel.Name = "friendsNameLabel";
            this.friendsNameLabel.Size = new System.Drawing.Size(109, 13);
            this.friendsNameLabel.TabIndex = 6;
            this.friendsNameLabel.Text = "Enter a friend\'s name:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(172, 116);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // writeNameButton
            // 
            this.writeNameButton.Location = new System.Drawing.Point(34, 116);
            this.writeNameButton.Name = "writeNameButton";
            this.writeNameButton.Size = new System.Drawing.Size(75, 23);
            this.writeNameButton.TabIndex = 4;
            this.writeNameButton.Text = "Write Name";
            this.writeNameButton.UseVisualStyleBackColor = true;
            this.writeNameButton.Click += new System.EventHandler(this.writeNameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 160);
            this.Controls.Add(this.friendsNameTextBox);
            this.Controls.Add(this.friendsNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeNameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox friendsNameTextBox;
        private System.Windows.Forms.Label friendsNameLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button writeNameButton;
    }
}

