namespace HashishAdmin
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.loginInfoLabel = new System.Windows.Forms.Label();
            this.editTextBox = new System.Windows.Forms.TextBox();
            this.trademarkLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.editBoxLabel = new System.Windows.Forms.Label();
            this.editLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginInfoLabel
            // 
            this.loginInfoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginInfoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.loginInfoLabel.Location = new System.Drawing.Point(15, 45);
            this.loginInfoLabel.Name = "loginInfoLabel";
            this.loginInfoLabel.Size = new System.Drawing.Size(263, 39);
            this.loginInfoLabel.TabIndex = 26;
            this.loginInfoLabel.Text = "Zde můžete upravovat různá nastavení uživatele.\r\n\r\n";
            // 
            // editTextBox
            // 
            this.editTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.editTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editTextBox.ForeColor = System.Drawing.Color.IndianRed;
            this.editTextBox.Location = new System.Drawing.Point(127, 111);
            this.editTextBox.Multiline = true;
            this.editTextBox.Name = "editTextBox";
            this.editTextBox.PasswordChar = '*';
            this.editTextBox.Size = new System.Drawing.Size(176, 30);
            this.editTextBox.TabIndex = 22;
            this.editTextBox.WordWrap = false;
            this.editTextBox.Click += new System.EventHandler(this.ClickRefresh);
            // 
            // trademarkLabel
            // 
            this.trademarkLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trademarkLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.trademarkLabel.Location = new System.Drawing.Point(81, 288);
            this.trademarkLabel.Name = "trademarkLabel";
            this.trademarkLabel.Size = new System.Drawing.Size(160, 24);
            this.trademarkLabel.TabIndex = 25;
            this.trademarkLabel.Text = "Mark Filliger Co.® 2023-2024";
            this.trademarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Gainsboro;
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editButton.ForeColor = System.Drawing.Color.IndianRed;
            this.editButton.Location = new System.Drawing.Point(203, 187);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 40);
            this.editButton.TabIndex = 24;
            this.editButton.Text = "Přihlásit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // editBoxLabel
            // 
            this.editBoxLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editBoxLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.editBoxLabel.Location = new System.Drawing.Point(14, 112);
            this.editBoxLabel.Name = "editBoxLabel";
            this.editBoxLabel.Size = new System.Drawing.Size(107, 29);
            this.editBoxLabel.TabIndex = 23;
            this.editBoxLabel.Text = "Nové Heslo";
            this.editBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editLabel.Location = new System.Drawing.Point(12, 9);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(189, 30);
            this.editLabel.TabIndex = 21;
            this.editLabel.Text = "Úprava Uživatele";
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.errorLabel.Location = new System.Drawing.Point(15, 144);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(299, 40);
            this.errorLabel.TabIndex = 27;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(334, 321);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.loginInfoLabel);
            this.Controls.Add(this.editTextBox);
            this.Controls.Add(this.trademarkLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.editBoxLabel);
            this.Controls.Add(this.editLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginInfoLabel;
        private System.Windows.Forms.TextBox editTextBox;
        private System.Windows.Forms.Label trademarkLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label editBoxLabel;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}