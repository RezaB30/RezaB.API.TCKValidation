namespace RezaB.API.TCKValidation.TestUnit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CommonGroupbox = new System.Windows.Forms.GroupBox();
            this.TCKNoTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.BirthDateDatepicker = new System.Windows.Forms.DateTimePicker();
            this.BirthCertificateGroupbox = new System.Windows.Forms.GroupBox();
            this.CertificateNoTextbox = new System.Windows.Forms.TextBox();
            this.CertificateSerialTextbox = new System.Windows.Forms.TextBox();
            this.TCKCardGroupbox = new System.Windows.Forms.GroupBox();
            this.TCKRegistrationNoTextbox = new System.Windows.Forms.TextBox();
            this.CheckValidityButton = new System.Windows.Forms.Button();
            this.CommonGroupbox.SuspendLayout();
            this.BirthCertificateGroupbox.SuspendLayout();
            this.TCKCardGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCK No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Birth Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Certificate No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Certificate Serial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "TCK Registration No:";
            // 
            // CommonGroupbox
            // 
            this.CommonGroupbox.Controls.Add(this.BirthDateDatepicker);
            this.CommonGroupbox.Controls.Add(this.LastNameTextbox);
            this.CommonGroupbox.Controls.Add(this.FirstNameTextbox);
            this.CommonGroupbox.Controls.Add(this.TCKNoTextbox);
            this.CommonGroupbox.Controls.Add(this.label1);
            this.CommonGroupbox.Controls.Add(this.label4);
            this.CommonGroupbox.Controls.Add(this.label2);
            this.CommonGroupbox.Controls.Add(this.label3);
            this.CommonGroupbox.Location = new System.Drawing.Point(12, 12);
            this.CommonGroupbox.Name = "CommonGroupbox";
            this.CommonGroupbox.Size = new System.Drawing.Size(279, 129);
            this.CommonGroupbox.TabIndex = 1;
            this.CommonGroupbox.TabStop = false;
            this.CommonGroupbox.Text = "Common";
            // 
            // TCKNoTextbox
            // 
            this.TCKNoTextbox.Location = new System.Drawing.Point(119, 19);
            this.TCKNoTextbox.MaxLength = 11;
            this.TCKNoTextbox.Name = "TCKNoTextbox";
            this.TCKNoTextbox.Size = new System.Drawing.Size(122, 20);
            this.TCKNoTextbox.TabIndex = 1;
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(119, 45);
            this.FirstNameTextbox.MaxLength = 200;
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(122, 20);
            this.FirstNameTextbox.TabIndex = 2;
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Location = new System.Drawing.Point(119, 71);
            this.LastNameTextbox.MaxLength = 200;
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(122, 20);
            this.LastNameTextbox.TabIndex = 3;
            // 
            // BirthDateDatepicker
            // 
            this.BirthDateDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDateDatepicker.Location = new System.Drawing.Point(119, 96);
            this.BirthDateDatepicker.Name = "BirthDateDatepicker";
            this.BirthDateDatepicker.Size = new System.Drawing.Size(122, 20);
            this.BirthDateDatepicker.TabIndex = 4;
            // 
            // BirthCertificateGroupbox
            // 
            this.BirthCertificateGroupbox.Controls.Add(this.CertificateSerialTextbox);
            this.BirthCertificateGroupbox.Controls.Add(this.CertificateNoTextbox);
            this.BirthCertificateGroupbox.Controls.Add(this.label5);
            this.BirthCertificateGroupbox.Controls.Add(this.label6);
            this.BirthCertificateGroupbox.Location = new System.Drawing.Point(12, 147);
            this.BirthCertificateGroupbox.Name = "BirthCertificateGroupbox";
            this.BirthCertificateGroupbox.Size = new System.Drawing.Size(279, 84);
            this.BirthCertificateGroupbox.TabIndex = 2;
            this.BirthCertificateGroupbox.TabStop = false;
            this.BirthCertificateGroupbox.Text = "Birth Certificate";
            // 
            // CertificateNoTextbox
            // 
            this.CertificateNoTextbox.Location = new System.Drawing.Point(119, 19);
            this.CertificateNoTextbox.MaxLength = 8;
            this.CertificateNoTextbox.Name = "CertificateNoTextbox";
            this.CertificateNoTextbox.Size = new System.Drawing.Size(122, 20);
            this.CertificateNoTextbox.TabIndex = 1;
            // 
            // CertificateSerialTextbox
            // 
            this.CertificateSerialTextbox.Location = new System.Drawing.Point(119, 45);
            this.CertificateSerialTextbox.MaxLength = 5;
            this.CertificateSerialTextbox.Name = "CertificateSerialTextbox";
            this.CertificateSerialTextbox.Size = new System.Drawing.Size(122, 20);
            this.CertificateSerialTextbox.TabIndex = 2;
            // 
            // TCKCardGroupbox
            // 
            this.TCKCardGroupbox.Controls.Add(this.TCKRegistrationNoTextbox);
            this.TCKCardGroupbox.Controls.Add(this.label7);
            this.TCKCardGroupbox.Location = new System.Drawing.Point(12, 237);
            this.TCKCardGroupbox.Name = "TCKCardGroupbox";
            this.TCKCardGroupbox.Size = new System.Drawing.Size(279, 51);
            this.TCKCardGroupbox.TabIndex = 3;
            this.TCKCardGroupbox.TabStop = false;
            this.TCKCardGroupbox.Text = "TCK Card";
            // 
            // TCKRegistrationNoTextbox
            // 
            this.TCKRegistrationNoTextbox.Location = new System.Drawing.Point(119, 19);
            this.TCKRegistrationNoTextbox.Name = "TCKRegistrationNoTextbox";
            this.TCKRegistrationNoTextbox.Size = new System.Drawing.Size(122, 20);
            this.TCKRegistrationNoTextbox.TabIndex = 1;
            // 
            // CheckValidityButton
            // 
            this.CheckValidityButton.Location = new System.Drawing.Point(160, 294);
            this.CheckValidityButton.Name = "CheckValidityButton";
            this.CheckValidityButton.Size = new System.Drawing.Size(131, 23);
            this.CheckValidityButton.TabIndex = 4;
            this.CheckValidityButton.Text = "Check Validity";
            this.CheckValidityButton.UseVisualStyleBackColor = true;
            this.CheckValidityButton.Click += new System.EventHandler(this.CheckValidityButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 326);
            this.Controls.Add(this.CheckValidityButton);
            this.Controls.Add(this.TCKCardGroupbox);
            this.Controls.Add(this.BirthCertificateGroupbox);
            this.Controls.Add(this.CommonGroupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCK Validation";
            this.CommonGroupbox.ResumeLayout(false);
            this.CommonGroupbox.PerformLayout();
            this.BirthCertificateGroupbox.ResumeLayout(false);
            this.BirthCertificateGroupbox.PerformLayout();
            this.TCKCardGroupbox.ResumeLayout(false);
            this.TCKCardGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox CommonGroupbox;
        private System.Windows.Forms.TextBox TCKNoTextbox;
        private System.Windows.Forms.TextBox FirstNameTextbox;
        private System.Windows.Forms.TextBox LastNameTextbox;
        private System.Windows.Forms.DateTimePicker BirthDateDatepicker;
        private System.Windows.Forms.GroupBox BirthCertificateGroupbox;
        private System.Windows.Forms.TextBox CertificateNoTextbox;
        private System.Windows.Forms.TextBox CertificateSerialTextbox;
        private System.Windows.Forms.GroupBox TCKCardGroupbox;
        private System.Windows.Forms.TextBox TCKRegistrationNoTextbox;
        private System.Windows.Forms.Button CheckValidityButton;
    }
}

