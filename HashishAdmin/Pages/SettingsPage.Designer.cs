namespace HashishAdmin
{
    partial class SettingsPage
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
            this.changeUserSettingsLabel = new System.Windows.Forms.Label();
            this.settingsPanel = new BottomBorderPanel();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeUserSettingsLabel
            // 
            this.changeUserSettingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeUserSettingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeUserSettingsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeUserSettingsLabel.Location = new System.Drawing.Point(0, 0);
            this.changeUserSettingsLabel.Name = "changeUserSettingsLabel";
            this.changeUserSettingsLabel.Size = new System.Drawing.Size(635, 57);
            this.changeUserSettingsLabel.TabIndex = 4;
            this.changeUserSettingsLabel.Text = "Change User Settings";
            this.changeUserSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.settingsPanel.Controls.Add(this.changeUserSettingsLabel);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(635, 57);
            this.settingsPanel.TabIndex = 5;
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.settingsPanel);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(635, 679);
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.settingsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label changeUserSettingsLabel;
        private BottomBorderPanel settingsPanel;
    }
}
