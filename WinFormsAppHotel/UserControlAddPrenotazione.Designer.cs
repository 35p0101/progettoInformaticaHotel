namespace WinFormsAppHotel
{
    partial class UserControlAddPrenotazione
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
            lbIdCliente = new Label();
            lbIdCamera = new Label();
            lbDataPartenza = new Label();
            lbDataArrivo = new Label();
            tbIdCliente = new TextBox();
            tbIdCamera = new TextBox();
            dtpDataArrivo = new DateTimePicker();
            dtpDataPartenza = new DateTimePicker();
            btnAggiungi = new Button();
            SuspendLayout();
            // 
            // lbIdCliente
            // 
            lbIdCliente.AutoSize = true;
            lbIdCliente.Font = new Font("Segoe UI", 10F);
            lbIdCliente.Location = new Point(23, 18);
            lbIdCliente.Name = "lbIdCliente";
            lbIdCliente.Size = new Size(89, 23);
            lbIdCliente.TabIndex = 0;
            lbIdCliente.Text = "Id cliente: ";
            // 
            // lbIdCamera
            // 
            lbIdCamera.AutoSize = true;
            lbIdCamera.Font = new Font("Segoe UI", 10F);
            lbIdCamera.Location = new Point(23, 75);
            lbIdCamera.Name = "lbIdCamera";
            lbIdCamera.Size = new Size(95, 23);
            lbIdCamera.TabIndex = 1;
            lbIdCamera.Text = "Id camera: ";
            // 
            // lbDataPartenza
            // 
            lbDataPartenza.AutoSize = true;
            lbDataPartenza.Font = new Font("Segoe UI", 10F);
            lbDataPartenza.Location = new Point(323, 119);
            lbDataPartenza.Name = "lbDataPartenza";
            lbDataPartenza.Size = new Size(139, 23);
            lbDataPartenza.TabIndex = 2;
            lbDataPartenza.Text = "data di partenza:";
            // 
            // lbDataArrivo
            // 
            lbDataArrivo.AutoSize = true;
            lbDataArrivo.Font = new Font("Segoe UI", 10F);
            lbDataArrivo.Location = new Point(336, 17);
            lbDataArrivo.Name = "lbDataArrivo";
            lbDataArrivo.Size = new Size(115, 23);
            lbDataArrivo.TabIndex = 3;
            lbDataArrivo.Text = "data di arrivo:";
            // 
            // tbIdCliente
            // 
            tbIdCliente.Font = new Font("Segoe UI", 10F);
            tbIdCliente.Location = new Point(136, 17);
            tbIdCliente.Name = "tbIdCliente";
            tbIdCliente.Size = new Size(125, 30);
            tbIdCliente.TabIndex = 4;
            // 
            // tbIdCamera
            // 
            tbIdCamera.Font = new Font("Segoe UI", 10F);
            tbIdCamera.Location = new Point(136, 75);
            tbIdCamera.Name = "tbIdCamera";
            tbIdCamera.Size = new Size(125, 30);
            tbIdCamera.TabIndex = 5;
            // 
            // dtpDataArrivo
            // 
            dtpDataArrivo.Location = new Point(280, 58);
            dtpDataArrivo.Name = "dtpDataArrivo";
            dtpDataArrivo.Size = new Size(250, 27);
            dtpDataArrivo.TabIndex = 6;
            // 
            // dtpDataPartenza
            // 
            dtpDataPartenza.Location = new Point(280, 156);
            dtpDataPartenza.Name = "dtpDataPartenza";
            dtpDataPartenza.Size = new Size(250, 27);
            dtpDataPartenza.TabIndex = 7;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Font = new Font("Segoe UI", 10F);
            btnAggiungi.Location = new Point(86, 144);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(110, 39);
            btnAggiungi.TabIndex = 8;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // UserControlAddPrenotazione
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAggiungi);
            Controls.Add(dtpDataPartenza);
            Controls.Add(dtpDataArrivo);
            Controls.Add(tbIdCamera);
            Controls.Add(tbIdCliente);
            Controls.Add(lbDataArrivo);
            Controls.Add(lbDataPartenza);
            Controls.Add(lbIdCamera);
            Controls.Add(lbIdCliente);
            Name = "UserControlAddPrenotazione";
            Size = new Size(557, 207);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbIdCliente;
        private Label lbIdCamera;
        private Label lbDataPartenza;
        private Label lbDataArrivo;
        private TextBox tbIdCliente;
        private TextBox tbIdCamera;
        private DateTimePicker dtpDataArrivo;
        private DateTimePicker dtpDataPartenza;
        private Button btnAggiungi;
    }
}
