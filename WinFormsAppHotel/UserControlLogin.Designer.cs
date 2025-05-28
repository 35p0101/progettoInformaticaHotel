namespace WinFormsAppHotel
{
    partial class UserControlLogin
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            lbUsername = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            lbPassword = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 13F);
            btnLogin.Location = new Point(214, 221);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 41);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 11F);
            lbUsername.Location = new Point(177, 44);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(101, 25);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username:";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(177, 72);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(192, 27);
            tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(177, 168);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(192, 27);
            tbPassword.TabIndex = 3;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 11F);
            lbPassword.Location = new Point(177, 126);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(95, 25);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password:";
            // 
            // UserControlLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lbUsername);
            Controls.Add(btnLogin);
            Name = "UserControlLogin";
            Size = new Size(593, 316);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lbUsername;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lbPassword;
    }
}
