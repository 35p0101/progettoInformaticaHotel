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
    public partial class UserControlAddPrenotazione : UserControl
    {
        public UserControlAddPrenotazione()
        {
            InitializeComponent();
            Visible = false;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Prenotazione nuovaPrenotazione = new Prenotazione(Convert.ToInt32(tbIdCliente.Text), Convert.ToInt32(tbIdCamera.Text), dtpDataArrivo.Value.Date,dtpDataPartenza.Value.Date);
            Prenotazione.GetData().Add(nuovaPrenotazione);
            Visible = false;

        }
    }
}
