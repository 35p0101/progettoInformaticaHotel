namespace WindowsFormsAppHotel
{
    partial class Form1
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbBenvenuto = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAttivita = new System.Windows.Forms.Button();
            this.btnCamere = new System.Windows.Forms.Button();
            this.btnClienti = new System.Windows.Forms.Button();
            this.btnTransazioni = new System.Windows.Forms.Button();
            this.btnPrenotazioni = new System.Windows.Forms.Button();
            this.btnDipendenti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBenvenuto
            // 
            this.lbBenvenuto.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbBenvenuto.Location = new System.Drawing.Point(316, 59);
            this.lbBenvenuto.Name = "lbBenvenuto";
            this.lbBenvenuto.Size = new System.Drawing.Size(147, 35);
            this.lbBenvenuto.TabIndex = 0;
            this.lbBenvenuto.Text = "Cadel Evans";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.Location = new System.Drawing.Point(646, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(122, 41);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnAttivita
            // 
            this.btnAttivita.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAttivita.Location = new System.Drawing.Point(150, 177);
            this.btnAttivita.Name = "btnAttivita";
            this.btnAttivita.Size = new System.Drawing.Size(141, 49);
            this.btnAttivita.TabIndex = 2;
            this.btnAttivita.Text = "Attivita";
            this.btnAttivita.UseVisualStyleBackColor = true;
            // 
            // btnCamere
            // 
            this.btnCamere.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCamere.Location = new System.Drawing.Point(320, 177);
            this.btnCamere.Name = "btnCamere";
            this.btnCamere.Size = new System.Drawing.Size(141, 49);
            this.btnCamere.TabIndex = 3;
            this.btnCamere.Text = "Camere";
            this.btnCamere.UseVisualStyleBackColor = true;
            // 
            // btnClienti
            // 
            this.btnClienti.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClienti.Location = new System.Drawing.Point(488, 177);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(141, 49);
            this.btnClienti.TabIndex = 4;
            this.btnClienti.Text = "Clienti";
            this.btnClienti.UseVisualStyleBackColor = true;
            // 
            // btnTransazioni
            // 
            this.btnTransazioni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTransazioni.Location = new System.Drawing.Point(488, 262);
            this.btnTransazioni.Name = "btnTransazioni";
            this.btnTransazioni.Size = new System.Drawing.Size(141, 49);
            this.btnTransazioni.TabIndex = 7;
            this.btnTransazioni.Text = "Transazioni";
            this.btnTransazioni.UseVisualStyleBackColor = true;
            // 
            // btnPrenotazioni
            // 
            this.btnPrenotazioni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrenotazioni.Location = new System.Drawing.Point(320, 262);
            this.btnPrenotazioni.Name = "btnPrenotazioni";
            this.btnPrenotazioni.Size = new System.Drawing.Size(141, 49);
            this.btnPrenotazioni.TabIndex = 6;
            this.btnPrenotazioni.Text = "Prenotazioni";
            this.btnPrenotazioni.UseVisualStyleBackColor = true;
            // 
            // btnDipendenti
            // 
            this.btnDipendenti.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDipendenti.Location = new System.Drawing.Point(150, 262);
            this.btnDipendenti.Name = "btnDipendenti";
            this.btnDipendenti.Size = new System.Drawing.Size(141, 49);
            this.btnDipendenti.TabIndex = 5;
            this.btnDipendenti.Text = "Dipendenti";
            this.btnDipendenti.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransazioni);
            this.Controls.Add(this.btnPrenotazioni);
            this.Controls.Add(this.btnDipendenti);
            this.Controls.Add(this.btnClienti);
            this.Controls.Add(this.btnCamere);
            this.Controls.Add(this.btnAttivita);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbBenvenuto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbBenvenuto;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAttivita;
        private System.Windows.Forms.Button btnCamere;
        private System.Windows.Forms.Button btnClienti;
        private System.Windows.Forms.Button btnTransazioni;
        private System.Windows.Forms.Button btnPrenotazioni;
        private System.Windows.Forms.Button btnDipendenti;
    }
}

