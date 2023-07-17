namespace GreetUser
{
    partial class Dashdoard
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
            this.FirstnameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.SayHelloButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstnameLabel
            // 
            this.FirstnameLabel.AutoSize = true;
            this.FirstnameLabel.Location = new System.Drawing.Point(72, 55);
            this.FirstnameLabel.Name = "FirstnameLabel";
            this.FirstnameLabel.Size = new System.Drawing.Size(108, 29);
            this.FirstnameLabel.TabIndex = 0;
            this.FirstnameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(72, 93);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(107, 29);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(198, 52);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(217, 35);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(198, 90);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(217, 35);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // SayHelloButton
            // 
            this.SayHelloButton.Location = new System.Drawing.Point(198, 153);
            this.SayHelloButton.Name = "SayHelloButton";
            this.SayHelloButton.Size = new System.Drawing.Size(98, 43);
            this.SayHelloButton.TabIndex = 4;
            this.SayHelloButton.Text = "Hello!";
            this.SayHelloButton.UseVisualStyleBackColor = true;
            this.SayHelloButton.Click += new System.EventHandler(this.SayHelloButton_Click);
            // 
            // Dashdoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 388);
            this.Controls.Add(this.SayHelloButton);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstnameLabel);
            this.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Dashdoard";
            this.Text = "UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstnameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Button SayHelloButton;
    }
}

