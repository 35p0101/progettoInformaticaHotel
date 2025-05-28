namespace WinFormsAppHotel
{
    partial class UserControlAggiungiStipendio
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
            lbStipendio = new Label();
            tbStipendio = new TextBox();
            label1 = new Label();
            tbNome = new TextBox();
            btnAddStipendio = new Button();
            lbNome = new Label();
            lbCognome = new Label();
            tbCognome = new TextBox();
            SuspendLayout();
            // 
            // lbStipendio
            // 
            lbStipendio.AutoSize = true;
            lbStipendio.Font = new Font("Segoe UI", 10F);
            lbStipendio.Location = new Point(39, 15);
            lbStipendio.Name = "lbStipendio";
            lbStipendio.Size = new Size(158, 23);
            lbStipendio.TabIndex = 0;
            lbStipendio.Text = "Aggiungi stipendio:";
            // 
            // tbStipendio
            // 
            tbStipendio.Font = new Font("Segoe UI", 10F);
            tbStipendio.Location = new Point(39, 54);
            tbStipendio.Name = "tbStipendio";
            tbStipendio.Size = new Size(163, 30);
            tbStipendio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(379, 15);
            label1.Name = "label1";
            label1.Size = new Size(168, 23);
            label1.TabIndex = 2;
            label1.Text = "A quale dipendente?";
            // 
            // tbNome
            // 
            tbNome.Font = new Font("Segoe UI", 10F);
            tbNome.Location = new Point(379, 54);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(166, 30);
            tbNome.TabIndex = 3;
            // 
            // btnAddStipendio
            // 
            btnAddStipendio.Location = new Point(410, 164);
            btnAddStipendio.Name = "btnAddStipendio";
            btnAddStipendio.Size = new Size(94, 29);
            btnAddStipendio.TabIndex = 4;
            btnAddStipendio.Text = "Aggiungi";
            btnAddStipendio.UseVisualStyleBackColor = true;
            btnAddStipendio.Click += btnAddStipendio_Click;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Segoe UI", 10F);
            lbNome.Location = new Point(273, 59);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(66, 23);
            lbNome.TabIndex = 5;
            lbNome.Text = "Nome: ";
            // 
            // lbCognome
            // 
            lbCognome.AutoSize = true;
            lbCognome.Font = new Font("Segoe UI", 10F);
            lbCognome.Location = new Point(273, 111);
            lbCognome.Name = "lbCognome";
            lbCognome.Size = new Size(94, 23);
            lbCognome.TabIndex = 7;
            lbCognome.Text = "Cognome: ";
            // 
            // tbCognome
            // 
            tbCognome.Font = new Font("Segoe UI", 10F);
            tbCognome.Location = new Point(379, 108);
            tbCognome.Name = "tbCognome";
            tbCognome.Size = new Size(166, 30);
            tbCognome.TabIndex = 6;
            // 
            // UserControlAggiungiStipendio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbCognome);
            Controls.Add(tbCognome);
            Controls.Add(lbNome);
            Controls.Add(btnAddStipendio);
            Controls.Add(tbNome);
            Controls.Add(label1);
            Controls.Add(tbStipendio);
            Controls.Add(lbStipendio);
            Name = "UserControlAggiungiStipendio";
            Size = new Size(621, 212);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStipendio;
        private TextBox tbStipendio;
        private Label label1;
        private TextBox tbNome;
        private Button btnAddStipendio;
        private Label lbNome;
        private Label lbCognome;
        private TextBox tbCognome;
    }
}
