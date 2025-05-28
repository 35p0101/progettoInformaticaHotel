namespace WinFormsAppHotel
{
    partial class UserControlCambioStatoCamera
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
            btnCambioStatoCamera = new Button();
            lbCambioStatoCamera = new Label();
            tbCambioStatoCamera = new TextBox();
            tbIdCamera = new TextBox();
            lbIdCamera = new Label();
            SuspendLayout();
            // 
            // btnCambioStatoCamera
            // 
            btnCambioStatoCamera.Font = new Font("Segoe UI", 10F);
            btnCambioStatoCamera.Location = new Point(205, 141);
            btnCambioStatoCamera.Name = "btnCambioStatoCamera";
            btnCambioStatoCamera.Size = new Size(94, 37);
            btnCambioStatoCamera.TabIndex = 0;
            btnCambioStatoCamera.Text = "Cambia ";
            btnCambioStatoCamera.UseVisualStyleBackColor = true;
            btnCambioStatoCamera.Click += btnCambioStatoCamera_Click;
            // 
            // lbCambioStatoCamera
            // 
            lbCambioStatoCamera.AutoSize = true;
            lbCambioStatoCamera.Font = new Font("Segoe UI", 10F);
            lbCambioStatoCamera.Location = new Point(61, 93);
            lbCambioStatoCamera.Name = "lbCambioStatoCamera";
            lbCambioStatoCamera.Size = new Size(176, 23);
            lbCambioStatoCamera.TabIndex = 1;
            lbCambioStatoCamera.Text = "Cambia stato camera:";
            // 
            // tbCambioStatoCamera
            // 
            tbCambioStatoCamera.Font = new Font("Segoe UI", 10F);
            tbCambioStatoCamera.Location = new Point(255, 89);
            tbCambioStatoCamera.Name = "tbCambioStatoCamera";
            tbCambioStatoCamera.Size = new Size(170, 30);
            tbCambioStatoCamera.TabIndex = 2;
            // 
            // tbIdCamera
            // 
            tbIdCamera.Font = new Font("Segoe UI", 10F);
            tbIdCamera.Location = new Point(255, 38);
            tbIdCamera.Name = "tbIdCamera";
            tbIdCamera.Size = new Size(170, 30);
            tbIdCamera.TabIndex = 3;
            // 
            // lbIdCamera
            // 
            lbIdCamera.AutoSize = true;
            lbIdCamera.Font = new Font("Segoe UI", 10F);
            lbIdCamera.Location = new Point(61, 38);
            lbIdCamera.Name = "lbIdCamera";
            lbIdCamera.Size = new Size(90, 23);
            lbIdCamera.TabIndex = 4;
            lbIdCamera.Text = "Id camera:";
            // 
            // UserControlCambioStatoCamera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbIdCamera);
            Controls.Add(tbIdCamera);
            Controls.Add(tbCambioStatoCamera);
            Controls.Add(lbCambioStatoCamera);
            Controls.Add(btnCambioStatoCamera);
            Name = "UserControlCambioStatoCamera";
            Size = new Size(489, 218);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCambioStatoCamera;
        private Label lbCambioStatoCamera;
        private TextBox tbCambioStatoCamera;
        private TextBox tbIdCamera;
        private Label lbIdCamera;
    }
}
