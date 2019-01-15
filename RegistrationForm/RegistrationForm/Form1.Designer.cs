namespace RegistrationForm
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBoxLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBoxLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.repeatPaswTextBox = new System.Windows.Forms.TextBox();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.birthdayTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.ssnTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.MaskedTextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.UpdButton = new System.Windows.Forms.Button();
            this.CancButton = new System.Windows.Forms.Button();
            this.fullNameTextlable = new System.Windows.Forms.Label();
            this.verificationCodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(140, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(219, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // nameTextBoxLabel
            // 
            this.nameTextBoxLabel.AutoSize = true;
            this.nameTextBoxLabel.Location = new System.Drawing.Point(31, 35);
            this.nameTextBoxLabel.Name = "nameTextBoxLabel";
            this.nameTextBoxLabel.Size = new System.Drawing.Size(35, 13);
            this.nameTextBoxLabel.TabIndex = 1;
            this.nameTextBoxLabel.Text = "Name";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(140, 62);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(219, 20);
            this.surnameTextBox.TabIndex = 0;
            this.surnameTextBox.Leave += new System.EventHandler(this.Surname_Leave);
            // 
            // surnameTextBoxLabel
            // 
            this.surnameTextBoxLabel.AutoSize = true;
            this.surnameTextBoxLabel.Location = new System.Drawing.Point(31, 69);
            this.surnameTextBoxLabel.Name = "surnameTextBoxLabel";
            this.surnameTextBoxLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameTextBoxLabel.TabIndex = 1;
            this.surnameTextBoxLabel.Text = "Surname";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(31, 96);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(54, 13);
            this.fullNameLabel.TabIndex = 3;
            this.fullNameLabel.Text = "Full Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(31, 128);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(140, 121);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(218, 20);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.Leave += new System.EventHandler(this.Password_leave);
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(31, 163);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.repeatPasswordLabel.TabIndex = 6;
            this.repeatPasswordLabel.Text = "Repeat Password";
            // 
            // repeatPaswTextBox
            // 
            this.repeatPaswTextBox.Location = new System.Drawing.Point(140, 161);
            this.repeatPaswTextBox.Name = "repeatPaswTextBox";
            this.repeatPaswTextBox.PasswordChar = '*';
            this.repeatPaswTextBox.Size = new System.Drawing.Size(219, 20);
            this.repeatPaswTextBox.TabIndex = 7;
            this.repeatPaswTextBox.Leave += new System.EventHandler(this.RepeasPassword_Leave);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(31, 204);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(45, 13);
            this.birthdayLabel.TabIndex = 8;
            this.birthdayLabel.Text = "Birthday";
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.Culture = new System.Globalization.CultureInfo("lv-LV");
            this.birthdayTextBox.Location = new System.Drawing.Point(140, 197);
            this.birthdayTextBox.Mask = "00/00/0000";
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(218, 20);
            this.birthdayTextBox.TabIndex = 9;
            this.birthdayTextBox.ValidatingType = typeof(System.DateTime);
            this.birthdayTextBox.Leave += new System.EventHandler(this.Birthday_Leave);
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(31, 240);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(29, 13);
            this.ssnLabel.TabIndex = 10;
            this.ssnLabel.Text = "SSN";
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Culture = new System.Globalization.CultureInfo("lv-LV");
            this.ssnTextBox.Location = new System.Drawing.Point(140, 236);
            this.ssnTextBox.Mask = "000000-00000";
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(217, 20);
            this.ssnTextBox.TabIndex = 11;
            this.ssnTextBox.Leave += new System.EventHandler(this.Ssn_Leave);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(31, 281);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "E-mail";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Culture = new System.Globalization.CultureInfo("lv-LV");
            this.emailTextBox.Location = new System.Drawing.Point(138, 274);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(218, 20);
            this.emailTextBox.TabIndex = 13;
            this.emailTextBox.Leave += new System.EventHandler(this.email_Leave);
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(34, 313);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(32, 13);
            this.codeLabel.TabIndex = 14;
            this.codeLabel.Text = "Code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(137, 314);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(219, 20);
            this.codeTextBox.TabIndex = 15;
            this.codeTextBox.Leave += new System.EventHandler(this.codeTextBox_Leave);
            // 
            // UpdButton
            // 
            this.UpdButton.Location = new System.Drawing.Point(137, 373);
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(86, 37);
            this.UpdButton.TabIndex = 16;
            this.UpdButton.Text = "Update";
            this.UpdButton.UseVisualStyleBackColor = true;
            this.UpdButton.Click += new System.EventHandler(this.Update_Click);
            // 
            // CancButton
            // 
            this.CancButton.Location = new System.Drawing.Point(268, 374);
            this.CancButton.Name = "CancButton";
            this.CancButton.Size = new System.Drawing.Size(88, 36);
            this.CancButton.TabIndex = 17;
            this.CancButton.Text = "Cancel";
            this.CancButton.UseVisualStyleBackColor = true;
            this.CancButton.Click += new System.EventHandler(this.Cancel_click);
            // 
            // fullNameTextlable
            // 
            this.fullNameTextlable.AutoSize = true;
            this.fullNameTextlable.Location = new System.Drawing.Point(137, 96);
            this.fullNameTextlable.Name = "fullNameTextlable";
            this.fullNameTextlable.Size = new System.Drawing.Size(54, 13);
            this.fullNameTextlable.TabIndex = 3;
            this.fullNameTextlable.Text = "Full Name";
            this.fullNameTextlable.Visible = false;
            // 
            // verificationCodeLabel
            // 
            this.verificationCodeLabel.AutoSize = true;
            this.verificationCodeLabel.Location = new System.Drawing.Point(394, 317);
            this.verificationCodeLabel.Name = "verificationCodeLabel";
            this.verificationCodeLabel.Size = new System.Drawing.Size(83, 13);
            this.verificationCodeLabel.TabIndex = 18;
            this.verificationCodeLabel.Text = "verificationCode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 455);
            this.Controls.Add(this.verificationCodeLabel);
            this.Controls.Add(this.CancButton);
            this.Controls.Add(this.UpdButton);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.ssnTextBox);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.repeatPaswTextBox);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.fullNameTextlable);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.nameTextBoxLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBoxLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameTextBoxLabel;

        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label surnameTextBoxLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.TextBox repeatPaswTextBox;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.MaskedTextBox birthdayTextBox;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.MaskedTextBox ssnTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.MaskedTextBox emailTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button UpdButton;
        private System.Windows.Forms.Button CancButton;
        private System.Windows.Forms.Label fullNameTextlable;
        private System.Windows.Forms.Label verificationCodeLabel;
    }
}

