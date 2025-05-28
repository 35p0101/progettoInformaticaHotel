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
    public partial class UserControlRemoveCliente : UserControl
    {
        public UserControlRemoveCliente()
        {
            InitializeComponent();
            Visible = false;
        }

        private void btnRimuoviCliente_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(tbIdCliente.Text); 
            foreach (Cliente c in Cliente.GetData())
            {
                if(c.Id == idCliente)
                {
                    Cliente.GetData().Remove(c);
                    break;
                }
            }
            Visible = false;
        }
    }
}
