namespace WinFormsAppHotel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbBenvenuto = new Label();
            btnAttivita = new Button();
            btnCamere = new Button();
            btnClienti = new Button();
            btnPrenotazioni = new Button();
            btnDipendenti = new Button();
            btnLogout = new Button();
            userControlLogin1 = new UserControlLogin();
            SuspendLayout();
            // 
            // lbBenvenuto
            // 
            lbBenvenuto.AutoSize = true;
            lbBenvenuto.Font = new Font("Segoe UI", 13F);
            lbBenvenuto.Location = new Point(314, 60);
            lbBenvenuto.Name = "lbBenvenuto";
            lbBenvenuto.Size = new Size(128, 30);
            lbBenvenuto.TabIndex = 0;
            lbBenvenuto.Text = "Cadel Evans";
            // 
            // btnAttivita
            // 
            btnAttivita.Location = new Point(165, 157);
            btnAttivita.Name = "btnAttivita";
            btnAttivita.Size = new Size(124, 47);
            btnAttivita.TabIndex = 1;
            btnAttivita.Text = "Attivita";
            btnAttivita.UseVisualStyleBackColor = true;
            btnAttivita.Click += btnAttivita_Click;
            // 
            // btnCamere
            // 
            btnCamere.Location = new Point(318, 157);
            btnCamere.Name = "btnCamere";
            btnCamere.Size = new Size(124, 47);
            btnCamere.TabIndex = 2;
            btnCamere.Text = "Camere";
            btnCamere.UseVisualStyleBackColor = true;
            btnCamere.Click += btnCamere_Click;
            // 
            // btnClienti
            // 
            btnClienti.Location = new Point(477, 157);
            btnClienti.Name = "btnClienti";
            btnClienti.Size = new Size(124, 47);
            btnClienti.TabIndex = 3;
            btnClienti.Text = "Clienti";
            btnClienti.UseVisualStyleBackColor = true;
            btnClienti.Click += btnClienti_Click;
            // 
            // btnPrenotazioni
            // 
            btnPrenotazioni.Location = new Point(396, 239);
            btnPrenotazioni.Name = "btnPrenotazioni";
            btnPrenotazioni.Size = new Size(124, 47);
            btnPrenotazioni.TabIndex = 5;
            btnPrenotazioni.Text = "Prenotazioni";
            btnPrenotazioni.UseVisualStyleBackColor = true;
            btnPrenotazioni.Click += btnPrenotazioni_Click;
            // 
            // btnDipendenti
            // 
            btnDipendenti.Location = new Point(230, 239);
            btnDipendenti.Name = "btnDipendenti";
            btnDipendenti.Size = new Size(124, 47);
            btnDipendenti.TabIndex = 4;
            btnDipendenti.Text = "Dipendenti";
            btnDipendenti.UseVisualStyleBackColor = true;
            btnDipendenti.Click += btnDipendenti_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(656, 37);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // userControlLogin1
            // 
            userControlLogin1.F = null;
            userControlLogin1.Location = new Point(122, 12);
            userControlLogin1.Name = "userControlLogin1";
            userControlLogin1.Size = new Size(687, 395);
            userControlLogin1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userControlLogin1);
            Controls.Add(btnLogout);
            Controls.Add(btnPrenotazioni);
            Controls.Add(btnDipendenti);
            Controls.Add(btnClienti);
            Controls.Add(btnCamere);
            Controls.Add(btnAttivita);
            Controls.Add(lbBenvenuto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbBenvenuto;
        private Button btnAttivita;
        private Button btnCamere;
        private Button btnClienti;
        private Button btnPrenotazioni;
        private Button btnDipendenti;
        private Button btnLogout;
        private UserControlLogin userControlLogin1;
    }
}
