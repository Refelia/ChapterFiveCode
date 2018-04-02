namespace Tutorial5_8
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
            this.exitButton = new System.Windows.Forms.Button();
            this.tossButton = new System.Windows.Forms.Button();
            this.tailPictureBox = new System.Windows.Forms.PictureBox();
            this.headPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(220, 213);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tossButton
            // 
            this.tossButton.Location = new System.Drawing.Point(25, 213);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(75, 23);
            this.tossButton.TabIndex = 3;
            this.tossButton.Text = "Toss";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // tailPictureBox
            // 
            this.tailPictureBox.BackgroundImage = global::Tutorial5_8.Properties.Resources.tailside;
            this.tailPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tailPictureBox.Location = new System.Drawing.Point(192, 12);
            this.tailPictureBox.Name = "tailPictureBox";
            this.tailPictureBox.Size = new System.Drawing.Size(170, 170);
            this.tailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailPictureBox.TabIndex = 1;
            this.tailPictureBox.TabStop = false;
            this.tailPictureBox.Visible = false;
            // 
            // headPictureBox
            // 
            this.headPictureBox.BackgroundImage = global::Tutorial5_8.Properties.Resources.headside;
            this.headPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headPictureBox.Location = new System.Drawing.Point(12, 12);
            this.headPictureBox.Name = "headPictureBox";
            this.headPictureBox.Size = new System.Drawing.Size(170, 170);
            this.headPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headPictureBox.TabIndex = 0;
            this.headPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 261);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tailPictureBox);
            this.Controls.Add(this.headPictureBox);
            this.Name = "Form1";
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.tailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox headPictureBox;
        private System.Windows.Forms.PictureBox tailPictureBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button tossButton;
    }
}

