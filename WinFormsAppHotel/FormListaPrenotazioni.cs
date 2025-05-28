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
    public partial class FormListaPrenotazioni : Form
    {
        public FormListaPrenotazioni()
        {
            InitializeComponent();
            dgvListaPrenotazioni.DataSource = Prenotazione.GetData();
        }

        private void btnAggiungiPrenotazione_Click(object sender, EventArgs e)
        {
            userControlAddPrenotazione1.Visible = true;
        }

        private void btnRimuoviPrenotazione_Click(object sender, EventArgs e)
        {
            userControlRimuoviPrenotazione1.Visible = true;
        }
    }
}
