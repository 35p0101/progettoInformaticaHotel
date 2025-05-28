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
    public partial class FormListaAttivita : Form
    {
        public FormListaAttivita()
        {
            InitializeComponent();
            dgvListaAttivita.DataSource = Attivita.GetData();
        }

        private void btnAggiungiAttivita_Click(object sender, EventArgs e)
        {
            userControlAggiungiAttivita1.Visible = true;
        }

        private void btnRimuoviAttivita_Click(object sender, EventArgs e)
        {
            userControlRimuoviAttivita1.Visible = true;
        }
    }
}
