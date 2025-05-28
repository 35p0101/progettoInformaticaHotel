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
    public partial class FormListaDipendenti : Form
    {
        public FormListaDipendenti()
        {
            InitializeComponent();
            dgvListaDipendenti.DataSource = Dipendente.GetData();
            userControlAggiungiStipendio1.F = this;
        }
    }
}
