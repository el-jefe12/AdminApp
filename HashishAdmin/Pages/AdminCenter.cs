using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HashishAdmin.Pages
{
    public partial class AdminCenter : UserControl
    {
        private DataHandler dh = new DataHandler();

        public AdminCenter()
        {
            InitializeComponent();
            InitializeUserPanels();
        }

        private void InitializeUserPanels()
        {
            foreach (User user in dh.userList)
            {
                CreateUserPanel(user);
            }
        }

        private void CreateUserPanel(User user)
        {
            // Create a new panel
            Panel userPanel = new Panel();
            userPanel.Size = new System.Drawing.Size(350, 50);
            userPanel.BackColor = System.Drawing.Color.Gainsboro;

            // Create the name panel
            Panel namePanel = new Panel();
            namePanel.Size = new System.Drawing.Size(150, 50);
            namePanel.Dock = DockStyle.Left;
            namePanel.BackColor = System.Drawing.SystemColors.HotTrack;

            // Add the name panel to the user panel
            userPanel.Controls.Add(namePanel);

            // Create the image panel
            Panel imagePanel = new Panel();
            imagePanel.Size = new System.Drawing.Size(50, 50);
            imagePanel.Left = 0;
            imagePanel.Dock = DockStyle.Left;
            if (user is Admin)
            {
                imagePanel.BackgroundImage = Properties.Resources.supportIconW;
            }
            else
            {
                imagePanel.BackgroundImage = Properties.Resources.userIconBigW;
            }
            imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            // Add the image panel to the user panel
            namePanel.Controls.Add(imagePanel);

            // Create content for the name panel (example: label displaying the username)
            Label nameLabel = new Label();
            nameLabel.Text = user.Name;
            nameLabel.Font = new System.Drawing.Font("Microsoft YaHei Light", 11, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            nameLabel.Dock = DockStyle.Right;
            namePanel.Controls.Add(nameLabel);

            // Create the button divider
            Panel buttonDividerPanel = new Panel();
            buttonDividerPanel.Size = new System.Drawing.Size(4, 50);
            buttonDividerPanel.Dock = DockStyle.Right;
            buttonDividerPanel.BackColor = System.Drawing.Color.WhiteSmoke;

            // Add the button divider before the "Edit" button
            userPanel.Controls.Add(buttonDividerPanel);

            // Add an "Edit" button at the end of each panel
            Button editButton = new Button();
            editButton.Text = "Edit";
            editButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 11, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));

            //editButton.BackgroundImage = Properties.Resources.editIconBig;
            //editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            editButton.Size = new System.Drawing.Size(50, 50);
            editButton.Dock = DockStyle.Right;
            editButton.Click += EditButton_Click;
            editButton.BackColor = System.Drawing.Color.Gainsboro;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;

            /*
            editButton.MouseEnter += (sender, e) => { editButton.BackColor = System.Drawing.Color.LightGray; };
            editButton.MouseLeave += (sender, e) => { editButton.BackColor = System.Drawing.Color.Gainsboro; };
            */

            userPanel.Controls.Add(editButton);

            userFlowLayoutPanel.Controls.Add(userPanel);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // Handle the click event for the "Edit" button
            Button clickedButton = (Button)sender;
            Panel parentPanel = (Panel)clickedButton.Parent;

            // Access information about the user from the panel
            string userName = parentPanel.Controls[0].Controls[1].Text; // works for some reason ????

            // Perform editing actions based on the user
            //MessageBox.Show("Editing user: " + userName);

            EditForm editForm = new EditForm(userName);
            editForm.ShowDialog();

            /*
            foreach (User user in dh.userList)
            {
                if (userName == user.Name)
                {
                    EditForm editForm = new EditForm(userName);
                    editForm.ShowDialog();
                }
            }
            */

        }
    }
}
