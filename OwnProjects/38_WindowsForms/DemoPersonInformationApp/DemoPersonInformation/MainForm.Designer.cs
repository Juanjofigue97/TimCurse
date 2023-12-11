namespace DemoPersonInformation
{
    partial class MainForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.cellphoneText = new System.Windows.Forms.TextBox();
            this.ageText = new System.Windows.Forms.TextBox();
            this.AddAddressButton = new System.Windows.Forms.Button();
            this.saveFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(62, 65);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(131, 29);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(62, 113);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(128, 29);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Location = new System.Drawing.Point(62, 155);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(124, 29);
            this.cellphoneLabel.TabIndex = 2;
            this.cellphoneLabel.Text = "Cellphone";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(62, 197);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(56, 29);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Age";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(62, 243);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(102, 29);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(221, 62);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(251, 35);
            this.firstNameText.TabIndex = 5;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(221, 110);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(251, 35);
            this.lastNameText.TabIndex = 6;
            // 
            // cellphoneText
            // 
            this.cellphoneText.Location = new System.Drawing.Point(221, 152);
            this.cellphoneText.Name = "cellphoneText";
            this.cellphoneText.Size = new System.Drawing.Size(251, 35);
            this.cellphoneText.TabIndex = 7;
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(221, 197);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(251, 35);
            this.ageText.TabIndex = 8;
            // 
            // AddAddressButton
            // 
            this.AddAddressButton.Location = new System.Drawing.Point(221, 240);
            this.AddAddressButton.Name = "AddAddressButton";
            this.AddAddressButton.Size = new System.Drawing.Size(86, 35);
            this.AddAddressButton.TabIndex = 10;
            this.AddAddressButton.Text = "Add";
            this.AddAddressButton.UseVisualStyleBackColor = true;
            this.AddAddressButton.Click += new System.EventHandler(this.AddAddressButton_Click);
            // 
            // saveFormButton
            // 
            this.saveFormButton.Location = new System.Drawing.Point(221, 314);
            this.saveFormButton.Name = "saveFormButton";
            this.saveFormButton.Size = new System.Drawing.Size(158, 41);
            this.saveFormButton.TabIndex = 11;
            this.saveFormButton.Text = "Save Data";
            this.saveFormButton.UseVisualStyleBackColor = true;
            this.saveFormButton.Click += new System.EventHandler(this.saveFormButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 391);
            this.Controls.Add(this.saveFormButton);
            this.Controls.Add(this.AddAddressButton);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.cellphoneText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.cellphoneLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "MainForm";
            this.Text = "Personal Information ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox cellphoneText;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Button AddAddressButton;
        private System.Windows.Forms.Button saveFormButton;
    }
}

