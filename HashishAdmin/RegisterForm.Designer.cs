namespace HashishAdmin
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.registrationLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox1 = new System.Windows.Forms.TextBox();
            this.passTextBox2 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passLabel1 = new System.Windows.Forms.Label();
            this.passLabel2 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.trademarkLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerInfoLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registrationLabel
            // 
            this.registrationLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registrationLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registrationLabel.Location = new System.Drawing.Point(12, 9);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(151, 36);
            this.registrationLabel.TabIndex = 1;
            this.registrationLabel.Text = "Registrace";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nameTextBox.Location = new System.Drawing.Point(110, 91);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(176, 30);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.WordWrap = false;
            this.nameTextBox.Click += new System.EventHandler(this.ClickRefresh);
            // 
            // passTextBox1
            // 
            this.passTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.passTextBox1.Location = new System.Drawing.Point(110, 127);
            this.passTextBox1.Multiline = true;
            this.passTextBox1.Name = "passTextBox1";
            this.passTextBox1.PasswordChar = '*';
            this.passTextBox1.Size = new System.Drawing.Size(176, 30);
            this.passTextBox1.TabIndex = 1;
            this.passTextBox1.WordWrap = false;
            this.passTextBox1.Click += new System.EventHandler(this.ClickRefresh);
            // 
            // passTextBox2
            // 
            this.passTextBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passTextBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passTextBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.passTextBox2.Location = new System.Drawing.Point(110, 163);
            this.passTextBox2.Multiline = true;
            this.passTextBox2.Name = "passTextBox2";
            this.passTextBox2.PasswordChar = '*';
            this.passTextBox2.Size = new System.Drawing.Size(176, 30);
            this.passTextBox2.TabIndex = 2;
            this.passTextBox2.WordWrap = false;
            this.passTextBox2.Click += new System.EventHandler(this.ClickRefresh);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nameLabel.Location = new System.Drawing.Point(14, 92);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(76, 29);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Jméno";
            // 
            // passLabel1
            // 
            this.passLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.passLabel1.Location = new System.Drawing.Point(14, 128);
            this.passLabel1.Name = "passLabel1";
            this.passLabel1.Size = new System.Drawing.Size(76, 29);
            this.passLabel1.TabIndex = 15;
            this.passLabel1.Text = "Heslo";
            // 
            // passLabel2
            // 
            this.passLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.passLabel2.Location = new System.Drawing.Point(12, 163);
            this.passLabel2.Name = "passLabel2";
            this.passLabel2.Size = new System.Drawing.Size(88, 30);
            this.passLabel2.TabIndex = 16;
            this.passLabel2.Text = "Heslo Znovu";
            this.passLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Gainsboro;
            this.returnButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.returnButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.returnButton.Location = new System.Drawing.Point(218, 241);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(100, 40);
            this.returnButton.TabIndex = 4;
            this.returnButton.Text = "Zpět";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // trademarkLabel
            // 
            this.trademarkLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trademarkLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.trademarkLabel.Location = new System.Drawing.Point(86, 284);
            this.trademarkLabel.Name = "trademarkLabel";
            this.trademarkLabel.Size = new System.Drawing.Size(160, 24);
            this.trademarkLabel.TabIndex = 18;
            this.trademarkLabel.Text = "Mark Filliger Co.® 2023-2024";
            this.trademarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Gainsboro;
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.registerButton.Location = new System.Drawing.Point(18, 241);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(110, 40);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Registrovat";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerInfoLabel
            // 
            this.registerInfoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerInfoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.registerInfoLabel.Location = new System.Drawing.Point(16, 46);
            this.registerInfoLabel.Name = "registerInfoLabel";
            this.registerInfoLabel.Size = new System.Drawing.Size(192, 43);
            this.registerInfoLabel.TabIndex = 19;
            this.registerInfoLabel.Text = "Registrujte se u nás! Stačí nám vaše jméno a heslo.\r\n";
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(19, 196);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(299, 40);
            this.errorLabel.TabIndex = 20;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(330, 317);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.registerInfoLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.trademarkLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.passLabel2);
            this.Controls.Add(this.passLabel1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.passTextBox2);
            this.Controls.Add(this.passTextBox1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.registrationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passTextBox1;
        private System.Windows.Forms.TextBox passTextBox2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passLabel1;
        private System.Windows.Forms.Label passLabel2;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label trademarkLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label registerInfoLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}