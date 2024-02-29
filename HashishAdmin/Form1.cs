using HashishAdmin.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HashishAdmin
{
    public partial class Form1 : Form
    {
        DataHandler dh = new DataHandler();

        public static string debugPath = Environment.CurrentDirectory;
        public static string solutionPath = new DirectoryInfo(debugPath).Parent.Parent.FullName;
        public static string imagePath = solutionPath + "\\gfx\\";

        private bool exitMessageBoxShown = false;

        public Image exitButtonB = Image.FromFile(imagePath + "\\exitIcon.png"); // black
        public Image exitButtonW = Image.FromFile(imagePath + "\\exitIconW.png"); // white

        public Image settingsButtonB = Image.FromFile(imagePath + "\\settingsIcon.png"); // black
        public Image settingsButtonW = Image.FromFile(imagePath + "\\settingsIconW.png"); // white

        private Color originalLabelColor = Color.Gainsboro;

        public Panel[] panels;

        public Panel[] panelSelectors; // blue lines on sides showing you which menu option is opened

        public Panel selectedPanel; // checks which panel button is selected to show appropriate side panel content

        public Panel parentPanel;

        public Form1()
        {
            InitializeComponent();
            panels = new Panel[] { menuItem1Panel, MenuItem2Panel, menuItem3Panel, menuItem4Panel, AdminMenuItemPanel };
            panelSelectors = new Panel[] { selectedPanel1, selectedPanel2, selectedPanel3, selectedPanel4, selectedPanelAdmin };

            foreach (Panel panel in panels)
            {
                // Attach event handlers for children controls within each panel
                foreach (Control control in panel.Controls)
                {
                    control.MouseEnter += IsHoveredItem;
                    control.MouseLeave += IsUnhoveredItem;
                    control.Click += IsClickedItem;
                }

                panel.MouseEnter += IsHoveredItem;
                panel.MouseLeave += IsUnhoveredItem;
                panel.Click += IsClickedItem;
            }

            exitPanel.MouseEnter += PictureButtonHover;
            exitPanel.MouseLeave += PictureButtonUnhover;
            settingsPanel.MouseEnter += PictureButtonHover;
            settingsPanel.MouseLeave += PictureButtonUnhover;

            exitPanel.Click -= PictureButtonClick; // has to be here...
            settingsPanel.Click -= PictureButtonClick;

            exitPanel.Click += PictureButtonClick;
            settingsPanel.Click += PictureButtonClick;


            // Ensure selectedPanel is initialized before calling SetSelectIndicatorColor
            selectedPanel = menuItem1Panel;

            SetupTooltips();

            SetSelectIndicatorColor();
        }

        public void SetupTooltips()
        {
            exitPanelTooltip.SetToolTip(exitPanel, "Odhlásí uživatele a opustí aplikaci.");
            settingsPanelTooltip.SetToolTip(settingsPanel, "Přejde do nastavení aplikace.");
        }


        public void HideSidePanelControls()
        {
            // Skrytí všech stránek

            foreach (UserControl usercontrol in sidePanelContentPanel.Controls)
            {
                usercontrol.Visible = false;
            }
        }

        public void PictureButtonClick(object sender, EventArgs e)
        {
            HideSidePanelControls();
            Panel panel = (Panel)sender;

            if (panel == exitPanel)
            {
                DialogResult exitDialogResult = MessageBox.Show("Opravdu chcete odejít?", "Opravdu?", MessageBoxButtons.OKCancel);

                if (exitDialogResult == DialogResult.OK)
                {
                    LogInForm logInForm = new LogInForm();
                    this.Hide();
                    logInForm.ShowDialog();
                }
                else
                {
                    Console.WriteLine("Zůstal");
                }

                exitMessageBoxShown = false;  // Nastavte, že MessageBox nebyl zobrazen
            }

            if (panel == settingsPanel)
            {
                SettingsSidePanelContent();
            }
        }


        public void PictureButtonHover(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;

            if (panel == exitPanel)
            {
                panel.BackgroundImage = exitButtonB;
            }
            else if (panel == settingsPanel)
            {
                panel.BackgroundImage = settingsButtonB;
            }

        }

        public void PictureButtonUnhover(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;

            if (panel == exitPanel)
            {
                panel.BackgroundImage = exitButtonW;
            }
            else if (panel == settingsPanel)
            {
                panel.BackgroundImage = settingsButtonW;
            }

        }

        public void IsClickedItem(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            // Find the parent panel of the control
            parentPanel = panels.FirstOrDefault(panel => panel.Controls.Contains(control));

            if (parentPanel != null)
            {
                // Change the color of selectedPanel and corresponding panel selector
                foreach (Panel selector in panelSelectors)
                {
                    selector.BackColor = originalLabelColor;
                }

                selectedPanel.BackColor = originalLabelColor;
                selectedPanel = parentPanel;
                selectedPanel.BackColor = Color.DarkGray; // Change this color to the desired selected color

                SetSelectIndicatorColor();

                HideSidePanelControls();

                // Perform actions based on the selected panel if needed
                if (selectedPanel == AdminMenuItemPanel)
                {
                    AdminCenterSidePanelContent();
                }
                else if (selectedPanel == menuItem1Panel)
                {
                    menuItem1SidePanelContent();
                }
                else if (selectedPanel == MenuItem2Panel)
                {
                    menuItem2SidePanelContent();
                }
                else if (selectedPanel == menuItem3Panel)
                {
                    menuItem3SidePanelContent();
                }
                else if (selectedPanel == menuItem4Panel)
                {
                    menuItem4SidePanelContent();
                }
                // Add more conditions for other panels as needed
            }
        }


        public void SetSelectIndicatorColor() // handles appearance of selected button
        {
            Panel correspondingSelector = panelSelectors[Array.IndexOf(panels, selectedPanel)];
            correspondingSelector.BackColor = SystemColors.HotTrack;
        }

        public void SettingsSidePanelContent()
        {
            sidePanelLabel.Text = "Settings";

            // Skrytí všech stránek


            // Vytvoření instance stránky nastavení a zobrazení
            SettingsPage settingsPage = new SettingsPage();
            settingsPage.Parent = sidePanelContentPanel;
            settingsPage.Dock = DockStyle.Fill;
            sidePanelContentPanel.Controls.Add(settingsPage);
            settingsPage.Visible = true;
        }

        // SIDE PANEL CONTENT

        public void AdminCenterSidePanelContent()
        {
            sidePanelLabel.Text = AdminMenuItemLabel.Text;

            AdminCenter adminCenter = new AdminCenter();
            adminCenter.Parent = sidePanelContentPanel;
            adminCenter.Dock = DockStyle.Fill;
            sidePanelContentPanel.Controls.Add(adminCenter);
            adminCenter.Visible = true;

        }

        public void menuItem1SidePanelContent()
        {
            sidePanelLabel.Text = menuItem1Label.Text;
        }

        public void menuItem2SidePanelContent()
        {
            sidePanelLabel.Text = menuItem2Label.Text;
        }

        public void menuItem3SidePanelContent()
        {
            sidePanelLabel.Text = menuItem3Label.Text;
        }

        public void menuItem4SidePanelContent()
        {
            sidePanelLabel.Text = MenuItem4Label.Text;
        }

        // END OF SIDE PANEL CONTENT

        public void IsHoveredItem(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            // Find the parent panel of the control
            Panel parentPanel = panels.FirstOrDefault(panel => panel.Controls.Contains(control));

            if (parentPanel != null)
            {
                parentPanel.BackColor = Color.LightGray;
            }
        }

        public void IsUnhoveredItem(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            // Find the parent panel of the control
            Panel parentPanel = panels.FirstOrDefault(panel => panel.Controls.Contains(control));

            if (parentPanel != null)
            {
                parentPanel.BackColor = originalLabelColor;
            }
        }
        public void SetLoggedUser(User user)
        {
            dh.loggedInUser = user;

            userLabel.Text = $"{dh.loggedInUser?.Name ?? "No User"}";

            if (dh.loggedInUser is Admin)
            {
                userTypeLabel.Text = "Administrator";
                AdminMenuItemPanel.Visible = true;
            }
            else
            {
                userTypeLabel.Text = "User";
                AdminMenuItemPanel.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void logoffLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Hide();
            logInForm.ShowDialog();

            // Close or Dispose other open forms if necessary
        }


        private void menuItem1Label_Click(object sender, EventArgs e)
        {

        }

        private void menuItem2Label_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void settingsPanel_Click(object sender, EventArgs e)
        {
            SettingsSidePanelContent();
        }
    }
}
