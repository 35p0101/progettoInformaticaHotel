namespace WinFormsAppHotel
{
    partial class UserControlRimuoviAttivita
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
            btnRimuoviAttivita = new Button();
            lbTipoAttivita = new Label();
            lbIdCliente = new Label();
            tbTipoAttivita = new TextBox();
            tbIdCliente = new TextBox();
            SuspendLayout();
            // 
            // btnRimuoviAttivita
            // 
            btnRimuoviAttivita.Location = new Point(177, 131);
            btnRimuoviAttivita.Name = "btnRimuoviAttivita";
            btnRimuoviAttivita.Size = new Size(94, 29);
            btnRimuoviAttivita.TabIndex = 0;
            btnRimuoviAttivita.Text = "Rimuovi";
            btnRimuoviAttivita.UseVisualStyleBackColor = true;
            btnRimuoviAttivita.Click += btnRimuoviAttivita_Click;
            // 
            // lbTipoAttivita
            // 
            lbTipoAttivita.AutoSize = true;
            lbTipoAttivita.Font = new Font("Segoe UI", 10F);
            lbTipoAttivita.Location = new Point(56, 23);
            lbTipoAttivita.Name = "lbTipoAttivita";
            lbTipoAttivita.Size = new Size(104, 23);
            lbTipoAttivita.TabIndex = 1;
            lbTipoAttivita.Text = "Tipo attività:";
            // 
            // lbIdCliente
            // 
            lbIdCliente.AutoSize = true;
            lbIdCliente.Font = new Font("Segoe UI", 10F);
            lbIdCliente.Location = new Point(56, 73);
            lbIdCliente.Name = "lbIdCliente";
            lbIdCliente.Size = new Size(89, 23);
            lbIdCliente.TabIndex = 2;
            lbIdCliente.Text = "Id cliente: ";
            // 
            // tbTipoAttivita
            // 
            tbTipoAttivita.Font = new Font("Segoe UI", 10F);
            tbTipoAttivita.Location = new Point(242, 23);
            tbTipoAttivita.Name = "tbTipoAttivita";
            tbTipoAttivita.Size = new Size(162, 30);
            tbTipoAttivita.TabIndex = 3;
            // 
            // tbIdCliente
            // 
            tbIdCliente.Font = new Font("Segoe UI", 10F);
            tbIdCliente.Location = new Point(242, 73);
            tbIdCliente.Name = "tbIdCliente";
            tbIdCliente.Size = new Size(162, 30);
            tbIdCliente.TabIndex = 4;
            // 
            // UserControlRimuoviAttivita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbIdCliente);
            Controls.Add(tbTipoAttivita);
            Controls.Add(lbIdCliente);
            Controls.Add(lbTipoAttivita);
            Controls.Add(btnRimuoviAttivita);
            Name = "UserControlRimuoviAttivita";
            Size = new Size(455, 201);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRimuoviAttivita;
        private Label lbTipoAttivita;
        private Label lbIdCliente;
        private TextBox tbTipoAttivita;
        private TextBox tbIdCliente;
    }
}
