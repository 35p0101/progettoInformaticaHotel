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
using WinFormsAppHotel;

namespace WinFormsAppHotel
{
    public partial class UserControlAggiungiStipendio : UserControl
    {
        private FormListaDipendenti f;
        public UserControlAggiungiStipendio()
        {
            InitializeComponent();
        }

        

        private void btnAddStipendio_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;
            string cognome = tbCognome.Text;
            int stipendio = Convert.ToInt32(tbStipendio.Text);

            foreach (Dipendente d in Dipendente.GetData())
            {
                if (d.Cognome == cognome && d.Nome == nome)
                {
                    d.Stipendio += stipendio;
                }
            }
            f.Refresh();
        }

        public FormListaDipendenti F { get => f; set => f = value; }

    }
}
