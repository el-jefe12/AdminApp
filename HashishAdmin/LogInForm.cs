using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashishAdmin
{
    public partial class LogInForm : Form
    {
        DataHandler dh = new DataHandler();
        Generation generation = new Generation();

        Form1 form = new Form1();
        public LogInForm()
        {
            InitializeComponent();
        }

        public void ClickRefresh(object sender, EventArgs e) // for error message to dissapear
        {
            // literally just works to refresh the error message, might have to add another one to other places with error messages (idk if this is a good method but shit)
            errorlabel.Text = "";
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Terminate the application when the login form is closing
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(this); // Pass the current instance of LogInForm
            this.Hide();
            registerForm.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string enteredPassword = "";
            string enteredName = "";
            dh.LoadFromXML();

            if (nameTextBox.Text != "" && passTextBox.Text != "")
            {
                enteredName = nameTextBox.Text;
                enteredPassword = passTextBox.Text;

                try
                {
                    // Retrieve the stored salt for the admin
                    byte[] storedSalt = null;
                    User foundUser = dh.userList.FirstOrDefault(u => string.Equals(enteredName, u.Name, StringComparison.OrdinalIgnoreCase));

                    if (foundUser != null)
                    {
                        storedSalt = Convert.FromBase64String(foundUser.Salt);
                        // Continue with the login logic using storedSalt

                        // Hash the entered password with the stored salt
                        string hashedPassword = generation.HashPassword(enteredPassword, storedSalt);

                        bool loginSuccessful = false;

                        foreach (User user in dh.userList)
                        {
                            Console.WriteLine($"Debug: Checking user: {user.Name}, stored hashed password: {user.Password}");

                            if (string.Equals(enteredName, user.Name, StringComparison.OrdinalIgnoreCase) && hashedPassword == user.Password)
                            {
                                // Login was successful
                                MessageBox.Show($"Přihlášen jako {user.Name}");
                                loginSuccessful = true;

                                form.SetLoggedUser(user);

                                this.Hide();
                                form.ShowDialog();
                                break;
                            }
                        }

                        if (!loginSuccessful)
                        {
                            Console.WriteLine($"Debug: Login failed for user {enteredName}, entered hashed password: {hashedPassword}");

                            errorlabel.Text = "Nesprávné jméno nebo heslo.";
                        }
                    }
                    else
                    {
                        // Handle the case where the user is not found
                        Console.WriteLine($"Debug: User {enteredName} not found");
                        errorlabel.Text = "Uživatel nenalezen.";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error during login: {ex.Message}");
                    errorlabel.Text = "Chyba při přihlašování.";
                }
            }
            else
            {
                errorlabel.Text = "Nezadané jméno nebo heslo.";
            }
        }

    }
}
