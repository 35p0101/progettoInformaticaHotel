namespace WinFormsAppHotel
{
    partial class UserControlAggiungiAttivita
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
            btnAggiungiAttivita = new Button();
            tbTipoAttivita = new TextBox();
            tbIdCliente = new TextBox();
            dtpDataInizio = new DateTimePicker();
            lbTipoAttivita = new Label();
            lbDataInizio = new Label();
            lbIIdCliente = new Label();
            SuspendLayout();
            // 
            // btnAggiungiAttivita
            // 
            btnAggiungiAttivita.Font = new Font("Segoe UI", 10F);
            btnAggiungiAttivita.Location = new Point(149, 183);
            btnAggiungiAttivita.Name = "btnAggiungiAttivita";
            btnAggiungiAttivita.Size = new Size(113, 38);
            btnAggiungiAttivita.TabIndex = 0;
            btnAggiungiAttivita.Text = "Aggiungi";
            btnAggiungiAttivita.UseVisualStyleBackColor = true;
            btnAggiungiAttivita.Click += btnAggiungiAttivita_Click;
            // 
            // tbTipoAttivita
            // 
            tbTipoAttivita.Font = new Font("Segoe UI", 10F);
            tbTipoAttivita.Location = new Point(226, 32);
            tbTipoAttivita.Name = "tbTipoAttivita";
            tbTipoAttivita.Size = new Size(160, 30);
            tbTipoAttivita.TabIndex = 1;
            // 
            // tbIdCliente
            // 
            tbIdCliente.Font = new Font("Segoe UI", 10F);
            tbIdCliente.Location = new Point(226, 134);
            tbIdCliente.Name = "tbIdCliente";
            tbIdCliente.Size = new Size(160, 30);
            tbIdCliente.TabIndex = 2;
            // 
            // dtpDataInizio
            // 
            dtpDataInizio.CalendarFont = new Font("Segoe UI", 10F);
            dtpDataInizio.Location = new Point(159, 85);
            dtpDataInizio.Name = "dtpDataInizio";
            dtpDataInizio.Size = new Size(250, 27);
            dtpDataInizio.TabIndex = 3;
            // 
            // lbTipoAttivita
            // 
            lbTipoAttivita.AutoSize = true;
            lbTipoAttivita.Font = new Font("Segoe UI", 10F);
            lbTipoAttivita.Location = new Point(38, 35);
            lbTipoAttivita.Name = "lbTipoAttivita";
            lbTipoAttivita.Size = new Size(104, 23);
            lbTipoAttivita.TabIndex = 4;
            lbTipoAttivita.Text = "Tipo attività:";
            // 
            // lbDataInizio
            // 
            lbDataInizio.AutoSize = true;
            lbDataInizio.Font = new Font("Segoe UI", 10F);
            lbDataInizio.Location = new Point(38, 85);
            lbDataInizio.Name = "lbDataInizio";
            lbDataInizio.Size = new Size(96, 23);
            lbDataInizio.TabIndex = 5;
            lbDataInizio.Text = "Data Inizio:";
            // 
            // lbIIdCliente
            // 
            lbIIdCliente.AutoSize = true;
            lbIIdCliente.Font = new Font("Segoe UI", 10F);
            lbIIdCliente.Location = new Point(38, 134);
            lbIIdCliente.Name = "lbIIdCliente";
            lbIIdCliente.Size = new Size(87, 23);
            lbIIdCliente.TabIndex = 6;
            lbIIdCliente.Text = "Id Cliente:";
            // 
            // UserControlAggiungiAttivita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbIIdCliente);
            Controls.Add(lbDataInizio);
            Controls.Add(lbTipoAttivita);
            Controls.Add(dtpDataInizio);
            Controls.Add(tbIdCliente);
            Controls.Add(tbTipoAttivita);
            Controls.Add(btnAggiungiAttivita);
            Name = "UserControlAggiungiAttivita";
            Size = new Size(421, 243);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAggiungiAttivita;
        private TextBox tbTipoAttivita;
        private TextBox tbIdCliente;
        private DateTimePicker dtpDataInizio;
        private Label lbTipoAttivita;
        private Label lbDataInizio;
        private Label lbIIdCliente;
    }
}
