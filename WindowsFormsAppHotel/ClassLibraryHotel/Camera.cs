using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryHotel;

namespace ClassLibraryHotel
{
    public class Camera
    {
        private static BindingList<Camera> camere = new BindingList<Camera>();
        private static int nextId = 1;

        private int id;
        private string tipoCamera;
        private string statoCamera;

        public Camera(string tipoCamera, string statoCamera)
        {
            id = nextId;
            nextId++;

            this.tipoCamera = tipoCamera;
            this.statoCamera = statoCamera;
            camere.Add(this);
        }

        public int Id { get => id; }
        public string TipoCamera { get => tipoCamera; set => tipoCamera = value; }
        public string StatoCamera { get => statoCamera; set => statoCamera = value; }

        private static BindingList<Camera> GetSampleData()
        {
            return new BindingList<Camera>
            {
                new Camera("Singola", "Disponibile"),
                new Camera("Matrimoniale", "Prenotata"),
                new Camera("Suite", "In Pulizia"),
                new Camera("Matrimoniale", "Disponibile"),
                new Camera("Singola", "Fuori Servizio")
            };
        }

        public static BindingList<Camera> GetData()
        {
            if (camere.Count <= 0) camere = GetSampleData();
            return camere;
        }
    }
}
