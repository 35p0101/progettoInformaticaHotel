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
    public partial class Form1 : Form
    {
        private GestoreHotel gestore;

        public Form1()
        {
            InitializeComponent();
            gestore = null;
            userControlLogin1.F = this;
        }
        public GestoreHotel Gestore
        {
            get => gestore; set
            {
                gestore = value;
                lbBenvenuto.Text = "Benvenuto " + gestore.Utente.Username;
            }
        }

        private void btnAttivita_Click(object sender, EventArgs e)
        {
            FormListaAttivita f = new FormListaAttivita();
            f.Visible = true;
        }

        private void btnCamere_Click(object sender, EventArgs e)
        {
            FormListaCamere f = new FormListaCamere();
            f.Visible = true;
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            FormListaClienti f = new FormListaClienti();
            f.Visible = true;
        }

        private void btnDipendenti_Click(object sender, EventArgs e)
        {
            FormListaDipendenti f = new FormListaDipendenti();
            f.Visible = true;
        }

        private void btnPrenotazioni_Click(object sender, EventArgs e)
        {
            FormListaPrenotazioni f = new FormListaPrenotazioni();
            f.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            userControlLogin1.Visible = true;
            userControlLogin1.Pulisci();
        }
    }
}
