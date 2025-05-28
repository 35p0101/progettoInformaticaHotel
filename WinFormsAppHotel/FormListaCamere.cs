using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryHotel;

namespace WinFormsAppHotel
{
    public partial class FormListaCamere : Form
    {
        public FormListaCamere()
        {
            InitializeComponent();
            dgvListaCamere.DataSource = Camera.GetData();
            userControlCambioStatoCamera1.F = this;
        }

        private void btnCambioStatoCamera_Click(object sender, EventArgs e)
        {
            userControlCambioStatoCamera1.Visible = true;
            
        }
    }
}
