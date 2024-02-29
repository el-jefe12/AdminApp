using System.Windows.Forms.VisualStyles;

namespace HashishAdmin.Pages
{
    partial class AdminCenter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.setUserPassPanel = new BottomBorderPanel();
            this.changeUserPasswordLabel = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.userFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.adminCenterContentLeft = new System.Windows.Forms.Panel();
            this.userPassTextPanel = new System.Windows.Forms.Panel();
            this.setPassAdminCenterLabel = new System.Windows.Forms.Label();
            this.setUserPassPanel.SuspendLayout();
            this.adminCenterContentLeft.SuspendLayout();
            this.userPassTextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLabel.Location = new System.Drawing.Point(0, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(400, 80);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "\r\nVyberte si uživatele a změňte mu heslo. Pro změnění hesla klikněte na tlačítko " +
    "\"Edit\" u vybraného uživatele.\r\n\r\n";
            // 
            // setUserPassPanel
            // 
            this.setUserPassPanel.BackColor = System.Drawing.Color.Transparent;
            this.setUserPassPanel.Controls.Add(this.changeUserPasswordLabel);
            this.setUserPassPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.setUserPassPanel.Location = new System.Drawing.Point(0, 0);
            this.setUserPassPanel.Name = "setUserPassPanel";
            this.setUserPassPanel.Size = new System.Drawing.Size(635, 57);
            this.setUserPassPanel.TabIndex = 8;
            // 
            // changeUserPasswordLabel
            // 
            this.changeUserPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeUserPasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeUserPasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeUserPasswordLabel.Location = new System.Drawing.Point(0, 0);
            this.changeUserPasswordLabel.Name = "changeUserPasswordLabel";
            this.changeUserPasswordLabel.Size = new System.Drawing.Size(635, 57);
            this.changeUserPasswordLabel.TabIndex = 5;
            this.changeUserPasswordLabel.Text = "Edit User";
            this.changeUserPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userFlowLayoutPanel
            // 
            this.userFlowLayoutPanel.AutoScroll = true;
            this.userFlowLayoutPanel.AutoSize = true;
            this.userFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userFlowLayoutPanel.Location = new System.Drawing.Point(0, 80);
            this.userFlowLayoutPanel.Name = "userFlowLayoutPanel";
            this.userFlowLayoutPanel.Size = new System.Drawing.Size(400, 542);
            this.userFlowLayoutPanel.TabIndex = 9;
            // 
            // adminCenterContentLeft
            // 
            this.adminCenterContentLeft.Controls.Add(this.userFlowLayoutPanel);
            this.adminCenterContentLeft.Controls.Add(this.userPassTextPanel);
            this.adminCenterContentLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminCenterContentLeft.Location = new System.Drawing.Point(0, 57);
            this.adminCenterContentLeft.Name = "adminCenterContentLeft";
            this.adminCenterContentLeft.Size = new System.Drawing.Size(400, 622);
            this.adminCenterContentLeft.TabIndex = 10;
            // 
            // userPassTextPanel
            // 
            this.userPassTextPanel.Controls.Add(this.usernameLabel);
            this.userPassTextPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPassTextPanel.Location = new System.Drawing.Point(0, 0);
            this.userPassTextPanel.Name = "userPassTextPanel";
            this.userPassTextPanel.Size = new System.Drawing.Size(400, 80);
            this.userPassTextPanel.TabIndex = 0;
            // 
            // setPassAdminCenterLabel
            // 
            this.setPassAdminCenterLabel.Location = new System.Drawing.Point(0, 0);
            this.setPassAdminCenterLabel.Name = "setPassAdminCenterLabel";
            this.setPassAdminCenterLabel.Size = new System.Drawing.Size(100, 23);
            this.setPassAdminCenterLabel.TabIndex = 0;
            // 
            // AdminCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.adminCenterContentLeft);
            this.Controls.Add(this.setUserPassPanel);
            this.Name = "AdminCenter";
            this.Size = new System.Drawing.Size(635, 679);
            this.setUserPassPanel.ResumeLayout(false);
            this.adminCenterContentLeft.ResumeLayout(false);
            this.adminCenterContentLeft.PerformLayout();
            this.userPassTextPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label setPassAdminCenterLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        //private System.Windows.Forms.Panel setUserPassPanel;
        private BottomBorderPanel setUserPassPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.FlowLayoutPanel userFlowLayoutPanel;
        private System.Windows.Forms.Panel adminCenterContentLeft;
        private System.Windows.Forms.Panel userPassTextPanel;
        private System.Windows.Forms.Label changeUserPasswordLabel;
    }
}
