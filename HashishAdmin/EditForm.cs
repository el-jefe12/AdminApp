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
    public partial class EditForm : Form
    {
        DataHandler dh = new DataHandler();
        Generation generation = new Generation();
        string selectedUser;
        public EditForm(string userName)
        {
            selectedUser = userName;
            InitializeComponent();
            SetupEditForm();
        }

        public void SetupEditForm()
        {
            editLabel.Text = $"Úprava uživatele {selectedUser}";
        }

        public void ClickRefresh(object sender, EventArgs e) // for error message to dissapear
        {
            // literally just works to refresh the error message, might have to add another one to other places with error messages (idk if this is a good method but shit)
            errorLabel.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(editTextBox.Text))
            {
                string password = editTextBox.Text;

                // Generate a new salt for the user
                byte[] salt = generation.GenerateSalt();

                // Hash the password with the generated salt
                string hashedPassword = generation.HashPassword(password, salt);

                foreach (User user in dh.userList)
                {
                    if (user.Name == selectedUser)
                    {
                        user.Salt = Convert.ToBase64String(salt);
                        user.Password = hashedPassword;
                    }
                }

                dh.SaveToXML();

                MessageBox.Show($"Heslo pro uživatele {selectedUser} bylo změměno.");

                this.Hide();
            }
            else
            {
                errorLabel.Text = "Pole pro zadání nového hesla je prázdné!";
            }
        }
    }
}
