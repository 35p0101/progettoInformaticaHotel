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
    public partial class UserControlLogin : UserControl
    {
        private Form1 f;
        public UserControlLogin()
        {
            InitializeComponent();
            f = null;
        }
        public Form1 F { get => f; set => f = value; }

        public void Pulisci()
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            foreach (Dipendente dip in Dipendente.GetData())
            {
                if (dip is Amministratore && ((Amministratore)dip).Login(username, password))
                {
                    GestoreHotel g = new GestoreHotel((Amministratore)dip);
                    f.Gestore = g;

                    Visible = false;
                    break;
                }
            }
        }
    }
}
