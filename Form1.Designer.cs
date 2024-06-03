namespace CSC240_08_03_ManyButtons_jmr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RedButton = new Button();
            WhiteButton = new Button();
            BlueButton = new Button();
            favoriteButton = new Button();
            SuspendLayout();
            // 
            // RedButton
            // 
            RedButton.Location = new Point(32, 65);
            RedButton.Name = "RedButton";
            RedButton.Size = new Size(112, 34);
            RedButton.TabIndex = 0;
            RedButton.Text = "Red";
            RedButton.UseVisualStyleBackColor = true;
            RedButton.Click += RedButton_Click;
            // 
            // WhiteButton
            // 
            WhiteButton.Location = new Point(195, 65);
            WhiteButton.Name = "WhiteButton";
            WhiteButton.Size = new Size(112, 34);
            WhiteButton.TabIndex = 1;
            WhiteButton.Text = "White";
            WhiteButton.UseVisualStyleBackColor = true;
            WhiteButton.Click += WhiteButton_Click;
            // 
            // BlueButton
            // 
            BlueButton.Location = new Point(378, 65);
            BlueButton.Name = "BlueButton";
            BlueButton.Size = new Size(112, 34);
            BlueButton.TabIndex = 2;
            BlueButton.Text = "Blue";
            BlueButton.UseVisualStyleBackColor = true;
            BlueButton.Click += BlueButton_Click;
            // 
            // favoriteButton
            // 
            favoriteButton.Location = new Point(548, 65);
            favoriteButton.Name = "favoriteButton";
            favoriteButton.Size = new Size(164, 34);
            favoriteButton.TabIndex = 3;
            favoriteButton.Text = "My favorite color";
            favoriteButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 265);
            Controls.Add(favoriteButton);
            Controls.Add(BlueButton);
            Controls.Add(WhiteButton);
            Controls.Add(RedButton);
            Name = "Form1";
            Text = "Many Buttons";
            ResumeLayout(false);
        }

        #endregion

        private Button RedButton;
        private Button WhiteButton;
        private Button BlueButton;
        private Button favoriteButton;
    }
}
