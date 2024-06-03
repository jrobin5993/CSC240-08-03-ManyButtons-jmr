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
            redButton = new Button();
            whiteButton = new Button();
            blueButton = new Button();
            favoriteButton = new Button();
            SuspendLayout();
            // 
            // redButton
            // 
            redButton.Location = new Point(32, 65);
            redButton.Name = "redButton";
            redButton.Size = new Size(112, 34);
            redButton.TabIndex = 0;
            redButton.Text = "Red";
            redButton.UseVisualStyleBackColor = true;
            // 
            // whiteButton
            // 
            whiteButton.Location = new Point(195, 65);
            whiteButton.Name = "whiteButton";
            whiteButton.Size = new Size(112, 34);
            whiteButton.TabIndex = 1;
            whiteButton.Text = "White";
            whiteButton.UseVisualStyleBackColor = true;
            // 
            // blueButton
            // 
            blueButton.Location = new Point(378, 65);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(112, 34);
            blueButton.TabIndex = 2;
            blueButton.Text = "Blue";
            blueButton.UseVisualStyleBackColor = true;
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
            Controls.Add(blueButton);
            Controls.Add(whiteButton);
            Controls.Add(redButton);
            Name = "Form1";
            Text = "Many Buttons";
            ResumeLayout(false);
        }

        #endregion

        private Button redButton;
        private Button whiteButton;
        private Button blueButton;
        private Button favoriteButton;
    }
}
