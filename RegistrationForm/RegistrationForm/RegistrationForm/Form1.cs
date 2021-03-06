﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {


        public Form1() {
            InitializeComponent();
            RandomCodeGenerator();

        }

        public void Name_Leave(object sender, EventArgs e) {
            string name = nameTextBox.Text.ToString();
            if (name.Length <= 0) {
                MessageBox.Show("Field cannot be empty. Please enter your name.");
            } else if (!Regex.IsMatch(nameTextBox.Text, "^[a-zA-Z-]+$")) {
                MessageBox.Show("Only alphabetic characters allowed.");
            }
        }


        public void Surname_Leave(object sender, EventArgs e) {
            string surname = surnameTextBox.Text.ToString();
            if (surname.Length <= 0) {
                MessageBox.Show("Field cannot be empty. Please enter your surname.");
            } else if (!System.Text.RegularExpressions.Regex.IsMatch(surnameTextBox.Text, "^[a-zA-Z-]+$")) {
                MessageBox.Show("Only alphabetic characters allowed.");
            }
            CreateFullName(nameTextBox.Text, surnameTextBox.Text);
        }

        public void CreateFullName(string name, string surname) {
            fullNameTextlable.Text = name + " " + surname;
            fullNameTextlable.Visible = true;
        }

        public void Password_leave(object sender, EventArgs e) {
            string password = passwordTextBox.Text.ToString();
            if (password.Length <= 0) {
                MessageBox.Show("Field cannot be empty. Please enter password.");
            } else {
                bool enteredPass = validatePass(passwordTextBox.Text);
                if (!enteredPass) {
                    MessageBox.Show("Password must be 5 characters long and contain at least 1 upper case letter, 1 digit and 1 special character");
                }
            }
        }

        public static bool validatePass(string password) {
            bool isValid = false;
            bool isUpperCase = false, isDigit = false, isSymbol = false;

            if (password.Length >= 5) {
                foreach (var c in password) {
                    if (char.IsUpper(c)) isUpperCase = true;
                    if (char.IsDigit(c)) isDigit = true;
                    if (!char.IsLetterOrDigit(c)) isSymbol = true;

                    isValid = isUpperCase && isDigit && isSymbol;
                }

            } else {
                isValid = false;
            }

            return isValid;
            //return password.Length >= 5 && password.Any(x => char.IsDigit(x)) && password.Any(x => char.IsUpper(x)) && password.Any(x => char.IsSymbol(x));
        }

        public void RepeasPassword_Leave(object sender, EventArgs e) {
            string password2 = repeatPaswTextBox.Text;
            if (password2 != passwordTextBox.Text.ToString()) {
                MessageBox.Show("Password doesn't match");
            }
        }

        public void Birthday_Leave(object sender, EventArgs e) {
            string birthday = birthdayTextBox.Text;

            DateTime birthdayDate;
            bool isDate = DateTime.TryParse(birthday, out birthdayDate);

            string ssn = birthday.Replace(".", "").Remove(4, 2);
            ssnTextBox.Text = ssn;
        }

        public void Ssn_Leave(object sender, EventArgs e) {
            string ssnCompleate = ssnTextBox.Text;
            if (ssnCompleate.Length < 12) {
                MessageBox.Show("Length of SSN should be 12.");
            } else {
                string ssnFirstPart = birthdayTextBox.Text.Replace(".", "").Remove(4, 2);
                string ssnCompleateFirstPart = ssnCompleate.Substring(0, 6);
                if (ssnFirstPart != ssnCompleateFirstPart) {
                    MessageBox.Show("First part of SSN should match birthday.");
                }
            }
        }

        public void email_Leave(object sender, EventArgs e) {
            string email = emailTextBox.Text;

            Regex emailReg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (!emailReg.IsMatch(email)) {
                MessageBox.Show("Incorrect e-mail format. Please use format xxx@xxxx.xxx");
            }
        }

        public void Cancel_click(object sender, EventArgs e) {
            this.Close();
        }

        public void Update_Click(object sender, EventArgs e) {
            while (!codeTextBox.Text.Equals(verificationCodeLabel.Text)) {
                MessageBox.Show("Your entered code does not match verification code!");
                codeTextBox.Text = "";
            }

                MessageBox.Show("Successful registration for: \nFull Name: " + nameTextBox.Text + " " + surnameTextBox.Text +
                "\nBirthday: " + birthdayTextBox.Text +
                "\nSSN: " + ssnTextBox.Text +
                "\nE-mail: " + emailTextBox.Text);
        }

        public void RandomCodeGenerator() {
            Random randomCode = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var str = new char[5];
            for (int i = 0; i < str.Length; i++) {
                str[i] = chars[randomCode.Next(chars.Length)];
            }
            var randomSringValue = new String(str);
            verificationCodeLabel.Text = randomSringValue;
            verificationCodeLabel.Visible = true;
        }
        private void codeTextBox_Leave(object sender, EventArgs e) {
            if (!codeTextBox.Text.Equals(verificationCodeLabel.Text)) {
                MessageBox.Show("Your entered code does not match verification code!");

            }
        }
    }
}


