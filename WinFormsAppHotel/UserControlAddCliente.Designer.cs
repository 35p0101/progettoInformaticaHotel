namespace WinFormsAppHotel
{
    partial class UserControlAddCliente
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
            Button btnAddCliente;
            lbNome = new Label();
            lbCognome = new Label();
            lbDocumento = new Label();
            tbNome = new TextBox();
            tbCognome = new TextBox();
            tbDocumento = new TextBox();
            btnAddCliente = new Button();
            SuspendLayout();
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Segoe UI", 10F);
            lbNome.Location = new Point(58, 33);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(61, 23);
            lbNome.TabIndex = 0;
            lbNome.Text = "Nome:";
            // 
            // lbCognome
            // 
            lbCognome.AutoSize = true;
            lbCognome.Font = new Font("Segoe UI", 10F);
            lbCognome.Location = new Point(58, 89);
            lbCognome.Name = "lbCognome";
            lbCognome.Size = new Size(89, 23);
            lbCognome.TabIndex = 1;
            lbCognome.Text = "Cognome:";
            // 
            // lbDocumento
            // 
            lbDocumento.AutoSize = true;
            lbDocumento.Font = new Font("Segoe UI", 10F);
            lbDocumento.Location = new Point(58, 151);
            lbDocumento.Name = "lbDocumento";
            lbDocumento.Size = new Size(172, 23);
            lbDocumento.TabIndex = 2;
            lbDocumento.Text = "Numero Documento:";
            // 
            // btnAddCliente
            // 
            btnAddCliente.Location = new Point(191, 207);
            btnAddCliente.Name = "btnAddCliente";
            btnAddCliente.Size = new Size(94, 29);
            btnAddCliente.TabIndex = 3;
            btnAddCliente.Text = "Aggiungi";
            btnAddCliente.UseVisualStyleBackColor = true;
            btnAddCliente.Click += btnAddCliente_Click;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(271, 33);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(186, 27);
            tbNome.TabIndex = 4;
            // 
            // tbCognome
            // 
            tbCognome.Location = new Point(271, 88);
            tbCognome.Name = "tbCognome";
            tbCognome.Size = new Size(186, 27);
            tbCognome.TabIndex = 5;
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(271, 147);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(186, 27);
            tbDocumento.TabIndex = 6;
            // 
            // UserControlAddCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbDocumento);
            Controls.Add(tbCognome);
            Controls.Add(tbNome);
            Controls.Add(btnAddCliente);
            Controls.Add(lbDocumento);
            Controls.Add(lbCognome);
            Controls.Add(lbNome);
            Name = "UserControlAddCliente";
            Size = new Size(502, 275);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNome;
        private Label lbCognome;
        private Label lbDocumento;
        private TextBox tbNome;
        private TextBox tbCognome;
        private TextBox tbDocumento;
    }
}
