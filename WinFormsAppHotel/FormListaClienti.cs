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
    public partial class FormListaClienti : Form
    {
        public FormListaClienti()
        {
            InitializeComponent();
            dgvListaClienti.DataSource = Cliente.GetData();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            userControlAddCliente1.Visible = true;
        }

        private void btnRimuoviCliente_Click(object sender, EventArgs e)
        {
            userControlRemoveCliente1.Visible = true;
        }
    }
}
