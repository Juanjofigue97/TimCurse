namespace DemoPersonInformation
{
    partial class AddressForm
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
            this.secondAddressText = new System.Windows.Forms.TextBox();
            this.workAddressText = new System.Windows.Forms.TextBox();
            this.homeAddressText = new System.Windows.Forms.TextBox();
            this.secondHouseAddress = new System.Windows.Forms.Label();
            this.workAddressLabel = new System.Windows.Forms.Label();
            this.homeAddressLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secondAddressText
            // 
            this.secondAddressText.Location = new System.Drawing.Point(242, 188);
            this.secondAddressText.Name = "secondAddressText";
            this.secondAddressText.Size = new System.Drawing.Size(251, 35);
            this.secondAddressText.TabIndex = 13;
            // 
            // workAddressText
            // 
            this.workAddressText.Location = new System.Drawing.Point(242, 146);
            this.workAddressText.Name = "workAddressText";
            this.workAddressText.Size = new System.Drawing.Size(251, 35);
            this.workAddressText.TabIndex = 12;
            // 
            // homeAddressText
            // 
            this.homeAddressText.Location = new System.Drawing.Point(242, 98);
            this.homeAddressText.Name = "homeAddressText";
            this.homeAddressText.Size = new System.Drawing.Size(251, 35);
            this.homeAddressText.TabIndex = 11;
            // 
            // secondHouseAddress
            // 
            this.secondHouseAddress.AutoSize = true;
            this.secondHouseAddress.Location = new System.Drawing.Point(67, 194);
            this.secondHouseAddress.Name = "secondHouseAddress";
            this.secondHouseAddress.Size = new System.Drawing.Size(172, 29);
            this.secondHouseAddress.TabIndex = 10;
            this.secondHouseAddress.Text = "Second House";
            // 
            // workAddressLabel
            // 
            this.workAddressLabel.AutoSize = true;
            this.workAddressLabel.Location = new System.Drawing.Point(67, 152);
            this.workAddressLabel.Name = "workAddressLabel";
            this.workAddressLabel.Size = new System.Drawing.Size(69, 29);
            this.workAddressLabel.TabIndex = 9;
            this.workAddressLabel.Text = "Work";
            // 
            // homeAddressLabel
            // 
            this.homeAddressLabel.AutoSize = true;
            this.homeAddressLabel.Location = new System.Drawing.Point(67, 104);
            this.homeAddressLabel.Name = "homeAddressLabel";
            this.homeAddressLabel.Size = new System.Drawing.Size(78, 29);
            this.homeAddressLabel.TabIndex = 8;
            this.homeAddressLabel.Text = "Home";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(220, 248);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 40);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 326);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.secondAddressText);
            this.Controls.Add(this.workAddressText);
            this.Controls.Add(this.homeAddressText);
            this.Controls.Add(this.secondHouseAddress);
            this.Controls.Add(this.workAddressLabel);
            this.Controls.Add(this.homeAddressLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "AddressForm";
            this.Text = "Add Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox secondAddressText;
        private System.Windows.Forms.TextBox workAddressText;
        private System.Windows.Forms.TextBox homeAddressText;
        private System.Windows.Forms.Label secondHouseAddress;
        private System.Windows.Forms.Label workAddressLabel;
        private System.Windows.Forms.Label homeAddressLabel;
        private System.Windows.Forms.Button saveButton;
    }
}