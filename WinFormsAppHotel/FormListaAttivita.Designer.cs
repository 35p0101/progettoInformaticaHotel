namespace WinFormsAppHotel
{
    partial class FormListaAttivita
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
            dgvListaAttivita = new DataGridView();
            btnAggiungiAttivita = new Button();
            btnRimuoviAttivita = new Button();
            userControlAggiungiAttivita1 = new UserControlAggiungiAttivita();
            userControlRimuoviAttivita1 = new UserControlRimuoviAttivita();
            ((System.ComponentModel.ISupportInitialize)dgvListaAttivita).BeginInit();
            SuspendLayout();
            // 
            // dgvListaAttivita
            // 
            dgvListaAttivita.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaAttivita.Location = new Point(54, 223);
            dgvListaAttivita.Name = "dgvListaAttivita";
            dgvListaAttivita.RowHeadersWidth = 51;
            dgvListaAttivita.Size = new Size(697, 188);
            dgvListaAttivita.TabIndex = 0;
            // 
            // btnAggiungiAttivita
            // 
            btnAggiungiAttivita.Font = new Font("Segoe UI", 10F);
            btnAggiungiAttivita.Location = new Point(75, 37);
            btnAggiungiAttivita.Name = "btnAggiungiAttivita";
            btnAggiungiAttivita.Size = new Size(147, 42);
            btnAggiungiAttivita.TabIndex = 1;
            btnAggiungiAttivita.Text = "Aggiungi attività";
            btnAggiungiAttivita.UseVisualStyleBackColor = true;
            btnAggiungiAttivita.Click += btnAggiungiAttivita_Click;
            // 
            // btnRimuoviAttivita
            // 
            btnRimuoviAttivita.Font = new Font("Segoe UI", 10F);
            btnRimuoviAttivita.Location = new Point(75, 123);
            btnRimuoviAttivita.Name = "btnRimuoviAttivita";
            btnRimuoviAttivita.Size = new Size(147, 39);
            btnRimuoviAttivita.TabIndex = 2;
            btnRimuoviAttivita.Text = "Rimuovi Attività";
            btnRimuoviAttivita.UseVisualStyleBackColor = true;
            btnRimuoviAttivita.Click += btnRimuoviAttivita_Click;
            // 
            // userControlAggiungiAttivita1
            // 
            userControlAggiungiAttivita1.Location = new Point(300, -8);
            userControlAggiungiAttivita1.Name = "userControlAggiungiAttivita1";
            userControlAggiungiAttivita1.Size = new Size(526, 225);
            userControlAggiungiAttivita1.TabIndex = 3;
            userControlAggiungiAttivita1.Visible = false;
            // 
            // userControlRimuoviAttivita1
            // 
            userControlRimuoviAttivita1.Location = new Point(244, 12);
            userControlRimuoviAttivita1.Name = "userControlRimuoviAttivita1";
            userControlRimuoviAttivita1.Size = new Size(569, 205);
            userControlRimuoviAttivita1.TabIndex = 4;
            // 
            // FormListaAttivita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userControlRimuoviAttivita1);
            Controls.Add(userControlAggiungiAttivita1);
            Controls.Add(btnRimuoviAttivita);
            Controls.Add(btnAggiungiAttivita);
            Controls.Add(dgvListaAttivita);
            Name = "FormListaAttivita";
            Text = "FormListaAttivita";
            ((System.ComponentModel.ISupportInitialize)dgvListaAttivita).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaAttivita;
        private Button btnAggiungiAttivita;
        private Button btnRimuoviAttivita;
        private UserControlAggiungiAttivita userControlAggiungiAttivita1;
        private UserControlRimuoviAttivita userControlRimuoviAttivita1;
    }
}