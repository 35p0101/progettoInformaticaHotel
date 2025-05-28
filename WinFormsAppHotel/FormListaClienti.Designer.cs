namespace WinFormsAppHotel
{
    partial class FormListaClienti
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
            dgvListaClienti = new DataGridView();
            btnAggiungi = new Button();
            userControlAddCliente1 = new UserControlAddCliente();
            userControlRemoveCliente1 = new UserControlRemoveCliente();
            btnRimuoviCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaClienti).BeginInit();
            SuspendLayout();
            // 
            // dgvListaClienti
            // 
            dgvListaClienti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaClienti.Location = new Point(43, 208);
            dgvListaClienti.Name = "dgvListaClienti";
            dgvListaClienti.RowHeadersWidth = 51;
            dgvListaClienti.Size = new Size(713, 188);
            dgvListaClienti.TabIndex = 0;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Font = new Font("Segoe UI", 10F);
            btnAggiungi.Location = new Point(59, 36);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(143, 46);
            btnAggiungi.TabIndex = 1;
            btnAggiungi.Text = "Aggiungi cliente";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // userControlAddCliente1
            // 
            userControlAddCliente1.Location = new Point(241, 94);
            userControlAddCliente1.Name = "userControlAddCliente1";
            userControlAddCliente1.Size = new Size(628, 344);
            userControlAddCliente1.TabIndex = 2;
            userControlAddCliente1.Visible = false;
            // 
            // userControlRemoveCliente1
            // 
            userControlRemoveCliente1.Location = new Point(301, 12);
            userControlRemoveCliente1.Name = "userControlRemoveCliente1";
            userControlRemoveCliente1.Size = new Size(551, 305);
            userControlRemoveCliente1.TabIndex = 3;
            userControlRemoveCliente1.Visible = false;
            // 
            // btnRimuoviCliente
            // 
            btnRimuoviCliente.Font = new Font("Segoe UI", 10F);
            btnRimuoviCliente.Location = new Point(59, 122);
            btnRimuoviCliente.Name = "btnRimuoviCliente";
            btnRimuoviCliente.Size = new Size(143, 38);
            btnRimuoviCliente.TabIndex = 4;
            btnRimuoviCliente.Text = "Rimuovi cliente";
            btnRimuoviCliente.UseVisualStyleBackColor = true;
            btnRimuoviCliente.Click += btnRimuoviCliente_Click;
            // 
            // FormListaClienti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRimuoviCliente);
            Controls.Add(userControlRemoveCliente1);
            Controls.Add(userControlAddCliente1);
            Controls.Add(btnAggiungi);
            Controls.Add(dgvListaClienti);
            Name = "FormListaClienti";
            Text = "FormListaClienti";
            ((System.ComponentModel.ISupportInitialize)dgvListaClienti).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaClienti;
        private Button btnAggiungi;
        private UserControlAddCliente userControlAddCliente1;
        private UserControlRemoveCliente userControlRemoveCliente1;
        private Button btnRimuoviCliente;
    }
}