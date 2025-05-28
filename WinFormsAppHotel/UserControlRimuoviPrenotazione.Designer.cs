namespace WinFormsAppHotel
{
    partial class UserControlRimuoviPrenotazione
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
            btnRimuoviPrenotazione = new Button();
            lbIdCliente = new Label();
            lbIdCamera = new Label();
            tbIdCliente = new TextBox();
            tbIdCamera = new TextBox();
            SuspendLayout();
            // 
            // btnRimuoviPrenotazione
            // 
            btnRimuoviPrenotazione.Font = new Font("Segoe UI", 10F);
            btnRimuoviPrenotazione.Location = new Point(184, 168);
            btnRimuoviPrenotazione.Name = "btnRimuoviPrenotazione";
            btnRimuoviPrenotazione.Size = new Size(112, 35);
            btnRimuoviPrenotazione.TabIndex = 0;
            btnRimuoviPrenotazione.Text = "Rimuovi";
            btnRimuoviPrenotazione.UseVisualStyleBackColor = true;
            btnRimuoviPrenotazione.Click += btnRimuoviPrenotazione_Click;
            // 
            // lbIdCliente
            // 
            lbIdCliente.AutoSize = true;
            lbIdCliente.Font = new Font("Segoe UI", 10F);
            lbIdCliente.Location = new Point(63, 37);
            lbIdCliente.Name = "lbIdCliente";
            lbIdCliente.Size = new Size(84, 23);
            lbIdCliente.TabIndex = 1;
            lbIdCliente.Text = "Id cliente:";
            // 
            // lbIdCamera
            // 
            lbIdCamera.AutoSize = true;
            lbIdCamera.Font = new Font("Segoe UI", 10F);
            lbIdCamera.Location = new Point(63, 93);
            lbIdCamera.Name = "lbIdCamera";
            lbIdCamera.Size = new Size(90, 23);
            lbIdCamera.TabIndex = 2;
            lbIdCamera.Text = "Id camera:";
            // 
            // tbIdCliente
            // 
            tbIdCliente.Font = new Font("Segoe UI", 10F);
            tbIdCliente.Location = new Point(274, 34);
            tbIdCliente.Name = "tbIdCliente";
            tbIdCliente.Size = new Size(167, 30);
            tbIdCliente.TabIndex = 3;
            // 
            // tbIdCamera
            // 
            tbIdCamera.Font = new Font("Segoe UI", 10F);
            tbIdCamera.Location = new Point(274, 93);
            tbIdCamera.Name = "tbIdCamera";
            tbIdCamera.Size = new Size(167, 30);
            tbIdCamera.TabIndex = 4;
            // 
            // UserControlRimuoviPrenotazione
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbIdCamera);
            Controls.Add(tbIdCliente);
            Controls.Add(lbIdCamera);
            Controls.Add(lbIdCliente);
            Controls.Add(btnRimuoviPrenotazione);
            Name = "UserControlRimuoviPrenotazione";
            Size = new Size(495, 225);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRimuoviPrenotazione;
        private Label lbIdCliente;
        private Label lbIdCamera;
        private TextBox tbIdCliente;
        private TextBox tbIdCamera;
    }
}
