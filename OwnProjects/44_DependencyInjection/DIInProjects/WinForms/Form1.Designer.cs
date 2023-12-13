namespace WinForms
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
            HelloText = new Label();
            goodbyeText = new Label();
            SuspendLayout();
            // 
            // HelloText
            // 
            HelloText.AutoSize = true;
            HelloText.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HelloText.Location = new Point(311, 126);
            HelloText.Name = "HelloText";
            HelloText.Size = new Size(80, 37);
            HelloText.TabIndex = 0;
            HelloText.Text = "Hello";
            // 
            // goodbyeText
            // 
            goodbyeText.AutoSize = true;
            goodbyeText.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goodbyeText.Location = new Point(311, 183);
            goodbyeText.Name = "goodbyeText";
            goodbyeText.Size = new Size(80, 37);
            goodbyeText.TabIndex = 1;
            goodbyeText.Text = "Hello";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 600);
            Controls.Add(goodbyeText);
            Controls.Add(HelloText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HelloText;
        private Label goodbyeText;
    }
}
