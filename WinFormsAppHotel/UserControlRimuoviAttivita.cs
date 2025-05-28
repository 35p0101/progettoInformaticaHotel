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
    public partial class UserControlRimuoviAttivita : UserControl
    {
        public UserControlRimuoviAttivita()
        {
            InitializeComponent();
            Visible = false;
        }

        private void btnRimuoviAttivita_Click(object sender, EventArgs e)
        {
            string tipoAttivita = tbTipoAttivita.Text;
            int idCliente = Convert.ToInt32(tbIdCliente.Text);

            //System.InvalidOperationException: Collection was modified;
            //enumeration operation may not execute.
            //errore che non permette di iterare su Attivita.GetData() direttamente nel foreach

            var l = Attivita.GetData();
            var daRimuovere = new List<Attivita>();

            foreach (Attivita a in l)
            {
                if (a.TipoAttivita == tipoAttivita && a.IdCliente == idCliente)
                {
                    daRimuovere.Add(a);
                }
            }

            foreach (Attivita a in daRimuovere)
            {
                l.Remove(a);
            }

            Visible = false;
        }
    }
}
