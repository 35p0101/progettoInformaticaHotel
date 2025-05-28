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
    public partial class UserControlRimuoviPrenotazione : UserControl
    {
        public UserControlRimuoviPrenotazione()
        {
            InitializeComponent();
            Visible = false;
        }

        private void btnRimuoviPrenotazione_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(tbIdCliente.Text);
            int idCamera = Convert.ToInt32(tbIdCamera.Text);

            //System.InvalidOperationException: Collection was modified;
            //enumeration operation may not execute.
            //errore che non permette di iterare su Attivita.GetData() direttamente nel foreach

            var l = Prenotazione.GetData();
            var daRimuovere = new List<Prenotazione>();

            foreach (Prenotazione p in l)
            {
                if (p.IdCliente == idCliente && p.IdCamera == idCamera)
                {
                    daRimuovere.Add(p);
                }
            }

            foreach (Prenotazione p in daRimuovere)
            {
                l.Remove(p);
            }

            Visible = false;
        }
    }
}
