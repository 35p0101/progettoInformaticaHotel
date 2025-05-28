namespace WinFormsAppHotel
{
    partial class FormListaDipendenti
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
            dgvListaDipendenti = new DataGridView();
            userControlAggiungiStipendio1 = new UserControlAggiungiStipendio();
            ((System.ComponentModel.ISupportInitialize)dgvListaDipendenti).BeginInit();
            SuspendLayout();
            // 
            // dgvListaDipendenti
            // 
            dgvListaDipendenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaDipendenti.Location = new Point(54, 215);
            dgvListaDipendenti.Name = "dgvListaDipendenti";
            dgvListaDipendenti.RowHeadersWidth = 51;
            dgvListaDipendenti.Size = new Size(703, 208);
            dgvListaDipendenti.TabIndex = 0;
            // 
            // userControlAggiungiStipendio1
            // 
            userControlAggiungiStipendio1.F = null;
            userControlAggiungiStipendio1.Location = new Point(12, 12);
            userControlAggiungiStipendio1.Name = "userControlAggiungiStipendio1";
            userControlAggiungiStipendio1.Size = new Size(776, 197);
            userControlAggiungiStipendio1.TabIndex = 1;
            // 
            // FormListaDipendenti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userControlAggiungiStipendio1);
            Controls.Add(dgvListaDipendenti);
            Name = "FormListaDipendenti";
            Text = "FormListaDipendenti";
            ((System.ComponentModel.ISupportInitialize)dgvListaDipendenti).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaDipendenti;
        private UserControlAggiungiStipendio userControlAggiungiStipendio1;
    }
}