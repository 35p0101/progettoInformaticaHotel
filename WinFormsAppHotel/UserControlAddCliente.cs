using ClassLibraryHotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppHotel
{
    public partial class UserControlAddCliente : UserControl
    {
        public UserControlAddCliente()
        {
            InitializeComponent();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            Cliente nuovoCliente = new Cliente(tbNome.Text, tbCognome.Text, tbDocumento.Text);
            Visible = false;
        }
    }
}
