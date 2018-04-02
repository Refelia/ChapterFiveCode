namespace Tutorial5_4
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
            this.writeNameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.friendsNameLabel = new System.Windows.Forms.Label();
            this.friendsNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // writeNameButton
            // 
            this.writeNameButton.Location = new System.Drawing.Point(22, 99);
            this.writeNameButton.Name = "writeNameButton";
            this.writeNameButton.Size = new System.Drawing.Size(75, 23);
            this.writeNameButton.TabIndex = 0;
            this.writeNameButton.Text = "Write Name";
            this.writeNameButton.UseVisualStyleBackColor = true;
            this.writeNameButton.Click += new System.EventHandler(this.writeNameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(164, 99);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // friendsNameLabel
            // 
            this.friendsNameLabel.AutoSize = true;
            this.friendsNameLabel.Location = new System.Drawing.Point(40, 19);
            this.friendsNameLabel.Name = "friendsNameLabel";
            this.friendsNameLabel.Size = new System.Drawing.Size(109, 13);
            this.friendsNameLabel.TabIndex = 2;
            this.friendsNameLabel.Text = "Enter a friend\'s name:";
            // 
            // friendsNameTextBox
            // 
            this.friendsNameTextBox.Location = new System.Drawing.Point(43, 35);
            this.friendsNameTextBox.Name = "friendsNameTextBox";
            this.friendsNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.friendsNameTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 129);
            this.Controls.Add(this.friendsNameTextBox);
            this.Controls.Add(this.friendsNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeNameButton);
            this.Name = "Form1";
            this.Text = "Friend file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button writeNameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label friendsNameLabel;
        private System.Windows.Forms.TextBox friendsNameTextBox;
    }
}

