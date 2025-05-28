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
    public partial class UserControlCambioStatoCamera : UserControl
    {
        private FormListaCamere f;
        public UserControlCambioStatoCamera()
        {
            InitializeComponent();
            Visible = false;
        }

        private void btnCambioStatoCamera_Click(object sender, EventArgs e)
        {
            int idCamera = Convert.ToInt32(tbIdCamera.Text);
            string CambioStatoCamera = tbCambioStatoCamera.Text;

            foreach (Camera c in Camera.GetData())
            {
                if(c.Id == idCamera)
                {
                    c.StatoCamera = CambioStatoCamera;
                    break;
                }
            }
            f.Refresh();

            Visible = false;
        }

        public FormListaCamere F { get => f; set => f = value; }
    }
}