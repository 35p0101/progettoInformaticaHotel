namespace WinFormsAppHotel
{
    partial class FormListaPrenotazioni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvListaPrenotazioni = new DataGridView();
            btnAggiungiPrenotazione = new Button();
            btnRimuoviPrenotazione = new Button();
            userControlAddPrenotazione1 = new UserControlAddPrenotazione();
            userControlRimuoviPrenotazione1 = new UserControlRimuoviPrenotazione();
            ((System.ComponentModel.ISupportInitialize)dgvListaPrenotazioni).BeginInit();
            SuspendLayout();
            // 
            // dgvListaPrenotazioni
            // 
            dgvListaPrenotazioni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaPrenotazioni.Location = new Point(30, 220);
            dgvListaPrenotazioni.Name = "dgvListaPrenotazioni";
            dgvListaPrenotazioni.RowHeadersWidth = 51;
            dgvListaPrenotazioni.Size = new Size(729, 188);
            dgvListaPrenotazioni.TabIndex = 0;
            // 
            // btnAggiungiPrenotazione
            // 
            btnAggiungiPrenotazione.Font = new Font("Segoe UI", 10F);
            btnAggiungiPrenotazione.Location = new Point(30, 27);
            btnAggiungiPrenotazione.Name = "btnAggiungiPrenotazione";
            btnAggiungiPrenotazione.Size = new Size(207, 42);
            btnAggiungiPrenotazione.TabIndex = 1;
            btnAggiungiPrenotazione.Text = "Aggiungi prenotazione";
            btnAggiungiPrenotazione.UseVisualStyleBackColor = true;
            btnAggiungiPrenotazione.Click += btnAggiungiPrenotazione_Click;
            // 
            // btnRimuoviPrenotazione
            // 
            btnRimuoviPrenotazione.Font = new Font("Segoe UI", 10F);
            btnRimuoviPrenotazione.Location = new Point(30, 107);
            btnRimuoviPrenotazione.Name = "btnRimuoviPrenotazione";
            btnRimuoviPrenotazione.Size = new Size(207, 42);
            btnRimuoviPrenotazione.TabIndex = 2;
            btnRimuoviPrenotazione.Text = "Rimuovi prenotazione";
            btnRimuoviPrenotazione.UseVisualStyleBackColor = true;
            btnRimuoviPrenotazione.Click += btnRimuoviPrenotazione_Click;
            // 
            // userControlAddPrenotazione1
            // 
            userControlAddPrenotazione1.Location = new Point(243, 12);
            userControlAddPrenotazione1.Name = "userControlAddPrenotazione1";
            userControlAddPrenotazione1.Size = new Size(556, 202);
            userControlAddPrenotazione1.TabIndex = 3;
            userControlAddPrenotazione1.Visible = false;
            // 
            // userControlRimuoviPrenotazione1
            // 
            userControlRimuoviPrenotazione1.Location = new Point(271, 12);
            userControlRimuoviPrenotazione1.Name = "userControlRimuoviPrenotazione1";
            userControlRimuoviPrenotazione1.Size = new Size(488, 202);
            userControlRimuoviPrenotazione1.TabIndex = 4;
            // 
            // FormListaPrenotazioni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userControlRimuoviPrenotazione1);
            Controls.Add(userControlAddPrenotazione1);
            Controls.Add(btnRimuoviPrenotazione);
            Controls.Add(btnAggiungiPrenotazione);
            Controls.Add(dgvListaPrenotazioni);
            Name = "FormListaPrenotazioni";
            Text = "FormListaPrenotazioni";
            ((System.ComponentModel.ISupportInitialize)dgvListaPrenotazioni).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaPrenotazioni;
        private Button btnAggiungiPrenotazione;
        private Button btnRimuoviPrenotazione;
        private UserControlAddPrenotazione userControlAddPrenotazione1;
        private UserControlRimuoviPrenotazione userControlRimuoviPrenotazione1;
    }
}