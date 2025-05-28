namespace WinFormsAppHotel
{
    partial class UserControlRemoveCliente
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
            btnRimuoviCliente = new Button();
            lbIdCliente = new Label();
            tbIdCliente = new TextBox();
            SuspendLayout();
            // 
            // btnRimuoviCliente
            // 
            btnRimuoviCliente.Font = new Font("Segoe UI", 11F);
            btnRimuoviCliente.Location = new Point(168, 173);
            btnRimuoviCliente.Name = "btnRimuoviCliente";
            btnRimuoviCliente.Size = new Size(94, 38);
            btnRimuoviCliente.TabIndex = 0;
            btnRimuoviCliente.Text = "Rimuovi";
            btnRimuoviCliente.UseVisualStyleBackColor = true;
            btnRimuoviCliente.Click += btnRimuoviCliente_Click;
            // 
            // lbIdCliente
            // 
            lbIdCliente.AutoSize = true;
            lbIdCliente.Font = new Font("Segoe UI", 10F);
            lbIdCliente.Location = new Point(32, 96);
            lbIdCliente.Name = "lbIdCliente";
            lbIdCliente.Size = new Size(190, 23);
            lbIdCliente.TabIndex = 1;
            lbIdCliente.Text = "Id cliente da rimuovere:";
            // 
            // tbIdCliente
            // 
            tbIdCliente.Font = new Font("Segoe UI", 10F);
            tbIdCliente.Location = new Point(249, 93);
            tbIdCliente.Name = "tbIdCliente";
            tbIdCliente.Size = new Size(125, 30);
            tbIdCliente.TabIndex = 2;
            // 
            // UserControlRemoveCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbIdCliente);
            Controls.Add(lbIdCliente);
            Controls.Add(btnRimuoviCliente);
            Name = "UserControlRemoveCliente";
            Size = new Size(441, 244);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRimuoviCliente;
        private Label lbIdCliente;
        private TextBox tbIdCliente;
    }
}
