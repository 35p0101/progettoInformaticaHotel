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
    public partial class UserControlAggiungiAttivita : UserControl
    {
        public UserControlAggiungiAttivita()
        {
            InitializeComponent();
        }

        private void btnAggiungiAttivita_Click(object sender, EventArgs e)
        {
            Attivita nuovaAttivita = new Attivita(tbTipoAttivita.Text, dtpDataInizio.Value.Date , Convert.ToInt32(tbIdCliente.Text));
            Attivita.GetData().Add(nuovaAttivita);
            Visible = false;
        }
    }
}
