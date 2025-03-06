using System.Windows.Forms;

namespace RegistrationFormApp
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DateTimePicker dtpBirthDate;  
        private TextBox txtPersonalId;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnSubmit;
        private ErrorProvider errorProvider;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblBirthDate;
        private Label lblPersonalId;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblConfirmPassword;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtPersonalId = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblPersonalId = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.MistyRose;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(16, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 32);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.MistyRose;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(16, 119);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 32);
            this.txtLastName.TabIndex = 1;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dtpBirthDate.CalendarTitleBackColor = System.Drawing.Color.MistyRose;
            this.dtpBirthDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(16, 195);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 32);
            this.dtpBirthDate.TabIndex = 2;
            // 
            // txtPersonalId
            // 
            this.txtPersonalId.BackColor = System.Drawing.Color.MistyRose;
            this.txtPersonalId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPersonalId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonalId.ForeColor = System.Drawing.Color.Black;
            this.txtPersonalId.Location = new System.Drawing.Point(16, 261);
            this.txtPersonalId.Name = "txtPersonalId";
            this.txtPersonalId.Size = new System.Drawing.Size(200, 32);
            this.txtPersonalId.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.MistyRose;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(16, 333);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 32);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.MistyRose;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmail.Location = new System.Drawing.Point(16, 416);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 32);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.MistyRose;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(16, 502);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 32);
            this.txtPassword.TabIndex = 6;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.MistyRose;
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.Location = new System.Drawing.Point(16, 588);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 32);
            this.txtConfirmPassword.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSubmit.Location = new System.Drawing.Point(51, 646);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 36);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.Ivory;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFirstName.Location = new System.Drawing.Point(12, 11);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(154, 34);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "Firstname ";
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Ivory;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLastName.Location = new System.Drawing.Point(12, 87);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(141, 29);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Lastname ";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.BackColor = System.Drawing.Color.Ivory;
            this.lblBirthDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBirthDate.Location = new System.Drawing.Point(12, 160);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(141, 32);
            this.lblBirthDate.TabIndex = 11;
            this.lblBirthDate.Text = "Birthdate ";
            // 
            // lblPersonalId
            // 
            this.lblPersonalId.BackColor = System.Drawing.Color.Ivory;
            this.lblPersonalId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPersonalId.Location = new System.Drawing.Point(12, 229);
            this.lblPersonalId.Name = "lblPersonalId";
            this.lblPersonalId.Size = new System.Drawing.Size(166, 29);
            this.lblPersonalId.TabIndex = 12;
            this.lblPersonalId.Text = "Personal ID ";
            this.lblPersonalId.Click += new System.EventHandler(this.lblPersonalId_Click);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Ivory;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 299);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(119, 31);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "Phone Number ";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Ivory;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEmail.Location = new System.Drawing.Point(12, 384);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(119, 29);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email ";
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Ivory;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPassword.Location = new System.Drawing.Point(11, 455);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(124, 44);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password ";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Ivory;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.lblConfirmPassword.Location = new System.Drawing.Point(12, 551);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(295, 34);
            this.lblConfirmPassword.TabIndex = 16;
            this.lblConfirmPassword.Text = "Confirm Password ";
            // 
            // RegistrationForm
            // 
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(484, 719);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtPersonalId);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblPersonalId);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "RegistrationForm";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
