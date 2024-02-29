namespace HashishAdmin
{
    partial class LogInForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.loginLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.errorlabel = new System.Windows.Forms.Label();
            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.trademarkLabel = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.loginInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginLabel.Location = new System.Drawing.Point(9, 9);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(141, 36);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Přihlášení";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nameLabel.Location = new System.Drawing.Point(13, 84);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(76, 29);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Jméno";
            // 
            // passLabel
            // 
            this.passLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.passLabel.Location = new System.Drawing.Point(13, 127);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(62, 29);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Heslo";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Gainsboro;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginButton.Location = new System.Drawing.Point(178, 189);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 40);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Přihlásit";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // errorlabel
            // 
            this.errorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorlabel.ForeColor = System.Drawing.Color.Red;
            this.errorlabel.Location = new System.Drawing.Point(18, 164);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(300, 22);
            this.errorlabel.TabIndex = 5;
            this.errorlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.ActiveLinkColor = System.Drawing.Color.BlueViolet;
            this.registerLinkLabel.LinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerLinkLabel.Location = new System.Drawing.Point(58, 232);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.Size = new System.Drawing.Size(220, 24);
            this.registerLinkLabel.TabIndex = 4;
            this.registerLinkLabel.TabStop = true;
            this.registerLinkLabel.Text = "Pokud nemáte účet, můžete se zaregistrovat.\r\n\r\n";
            this.registerLinkLabel.VisitedLinkColor = System.Drawing.Color.BlueViolet;
            this.registerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLabel_LinkClicked);
            // 
            // trademarkLabel
            // 
            this.trademarkLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trademarkLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.trademarkLabel.Location = new System.Drawing.Point(81, 284);
            this.trademarkLabel.Name = "trademarkLabel";
            this.trademarkLabel.Size = new System.Drawing.Size(160, 24);
            this.trademarkLabel.TabIndex = 4;
            this.trademarkLabel.Text = "Mark Filliger Co.® 2023-2024";
            this.trademarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.passTextBox.Location = new System.Drawing.Point(102, 126);
            this.passTextBox.Multiline = true;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(176, 30);
            this.passTextBox.TabIndex = 2;
            this.passTextBox.WordWrap = false;
            this.passTextBox.Click += new System.EventHandler(this.ClickRefresh);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nameTextBox.Location = new System.Drawing.Point(102, 83);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(176, 30);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.WordWrap = false;
            this.nameTextBox.Click += new System.EventHandler(this.ClickRefresh);
            // 
            // loginInfoLabel
            // 
            this.loginInfoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginInfoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.loginInfoLabel.Location = new System.Drawing.Point(15, 41);
            this.loginInfoLabel.Name = "loginInfoLabel";
            this.loginInfoLabel.Size = new System.Drawing.Size(263, 43);
            this.loginInfoLabel.TabIndex = 20;
            this.loginInfoLabel.Text = "Pro přístup do aplikace se přihlaste pomocí jména a hesla. \r\n";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(330, 317);
            this.Controls.Add(this.loginInfoLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.trademarkLabel);
            this.Controls.Add(this.registerLinkLabel);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
        private System.Windows.Forms.Label trademarkLabel;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label loginInfoLabel;
    }
}