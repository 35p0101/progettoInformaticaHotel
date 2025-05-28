namespace WinFormsAppHotel
{
    partial class FormListaCamere
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
            dgvListaCamere = new DataGridView();
            btnCambioStatoCamera = new Button();
            userControlCambioStatoCamera1 = new UserControlCambioStatoCamera();
            ((System.ComponentModel.ISupportInitialize)dgvListaCamere).BeginInit();
            SuspendLayout();
            // 
            // dgvListaCamere
            // 
            dgvListaCamere.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCamere.Location = new Point(54, 213);
            dgvListaCamere.Name = "dgvListaCamere";
            dgvListaCamere.RowHeadersWidth = 51;
            dgvListaCamere.Size = new Size(682, 188);
            dgvListaCamere.TabIndex = 0;
            // 
            // btnCambioStatoCamera
            // 
            btnCambioStatoCamera.Font = new Font("Segoe UI", 10F);
            btnCambioStatoCamera.Location = new Point(54, 83);
            btnCambioStatoCamera.Name = "btnCambioStatoCamera";
            btnCambioStatoCamera.Size = new Size(205, 44);
            btnCambioStatoCamera.TabIndex = 1;
            btnCambioStatoCamera.Text = "Cambia stato camera";
            btnCambioStatoCamera.UseVisualStyleBackColor = true;
            btnCambioStatoCamera.Click += btnCambioStatoCamera_Click;
            // 
            // userControlCambioStatoCamera1
            // 
            userControlCambioStatoCamera1.Location = new Point(268, 12);
            userControlCambioStatoCamera1.Name = "userControlCambioStatoCamera1";
            userControlCambioStatoCamera1.Size = new Size(468, 185);
            userControlCambioStatoCamera1.TabIndex = 2;
            userControlCambioStatoCamera1.Visible = false;
            // 
            // FormListaCamere
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userControlCambioStatoCamera1);
            Controls.Add(btnCambioStatoCamera);
            Controls.Add(dgvListaCamere);
            Name = "FormListaCamere";
            Text = "FormListaCamere";
            ((System.ComponentModel.ISupportInitialize)dgvListaCamere).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaCamere;
        private Button btnCambioStatoCamera;
        private UserControlCambioStatoCamera userControlCambioStatoCamera1;
    }
}