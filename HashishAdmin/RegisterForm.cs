using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashishAdmin
{
    public partial class RegisterForm : Form
    {
        LogInForm loginform;
        Generation generation = new Generation();
        DataHandler datahandler = new DataHandler();

        public bool credentialsExist;
        public bool userExists;

        public RegisterForm(LogInForm loginFormInstance)
        {
            loginform = loginFormInstance;
            InitializeComponent();
        }
        public void ClickRefresh(object sender, EventArgs e) // for error message to dissapear
        {
            errorLabel.Text = "";
        }

        public bool RegisterUser(string userName, string password)
        {
            // Check if the user already exists
            bool userExists = datahandler.userList.Any(u => string.Equals(userName, u.Name, StringComparison.OrdinalIgnoreCase));

            if (userExists)
            {
                Console.WriteLine("UserExists true");
                // Handle the case where the user already exists
                errorLabel.Text = "Uživatel již existuje.";
                return false;  // Prevent further execution
            }

            // Generate a new salt for the user
            byte[] salt = generation.GenerateSalt();

            // Hash the password with the generated salt
            string hashedPassword = generation.HashPassword(password, salt);

            // Check if the combination of username and password already exists (after the rest of the logic)
            bool credentialsExist = datahandler.userList.Any(u =>
                string.Equals(userName, u.Name, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(hashedPassword, u.Password));

            if (credentialsExist)
            {
                Console.WriteLine("credentialsExist true");
                // Handle the case where the combination of username and password already exists
                errorLabel.Text = "Uživatel s tímto jménem a heslem již existuje.";
                return false;  // Prevent further execution
            }

            // Create a new User object with the relevant details
            User newUser = new User
            {
                Name = userName,
                Salt = Convert.ToBase64String(salt),
                Password = hashedPassword
            };

            // Add the new user to the user list
            datahandler.userList.Add(newUser);

            // Save the updated user list to XML
            datahandler.SaveToXML();

            // Inform the user that registration was successful
            MessageBox.Show($"Registrace uživatele {userName} byla úspěšná.");

            // Clear any previous error messages
            errorLabel.Text = "";

            return true;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (loginform != null && !loginform.IsDisposed)
            {
                loginform.Show();
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text) && !string.IsNullOrWhiteSpace(passTextBox1.Text))
            {
                if (passTextBox1.Text == passTextBox2.Text)
                {
                    bool registrationSuccessful = RegisterUser(nameTextBox.Text, passTextBox1.Text);
                    if (registrationSuccessful)
                    {
                        Console.WriteLine("ALL OK - closing registration");
                        this.Hide();
                        loginform.Show();
                    }
                    else
                    {
                        Console.WriteLine("Credentials exist - not closing registration");
                    }
                }
                else
                {
                    errorLabel.Text = "Hesla se neshodují.";
                }
            }
            else if (string.IsNullOrWhiteSpace(nameTextBox.Text) && !string.IsNullOrWhiteSpace(passTextBox1.Text) && !string.IsNullOrWhiteSpace(passTextBox2.Text))
            {
                errorLabel.Text = "Nezadali jste žádné jméno.";
            }
            else if (!string.IsNullOrWhiteSpace(nameTextBox.Text) && string.IsNullOrWhiteSpace(passTextBox1.Text))
            {
                errorLabel.Text = "Nezadali jste žádné heslo.";
            }
            else
            {
                errorLabel.Text = "Chyba.";
            }
        }

    }
}
