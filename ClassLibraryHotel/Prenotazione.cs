using ClassLibraryHotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHotel
{
    public class Prenotazione
    {
        private static BindingList<Prenotazione> prenotazioni = new BindingList<Prenotazione>();
        private static int nextId = 1;

        private int id;
        private int idCliente;
        private int idCamera;
        private DateTime dataArrivo;
        private DateTime dataPartenza;
        private bool confermata;

        public Prenotazione(int idCliente, int idCamera, DateTime dataArrivo, DateTime dataPartenza)
        {
            this.id = nextId++;
            this.idCliente = idCliente;
            this.idCamera = idCamera;
            this.dataArrivo = dataArrivo;
            this.dataPartenza = dataPartenza;
            this.confermata = false;
        }

        public int Id { get => id; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdCamera { get => idCamera; set => idCamera = value; }
        public DateTime DataArrivo { get => dataArrivo; set => dataArrivo = value; }
        public DateTime DataPartenza { get => dataPartenza; set => dataPartenza = value; }
        public bool Confermata { get => confermata; set => confermata = value; }

        public static BindingList<Prenotazione> GetPrenotazioni()
        {
            return prenotazioni;
        }

        private static BindingList<Prenotazione> GetSampleData()
        {
            return new BindingList<Prenotazione>
            {
                new Prenotazione(1, 1, new DateTime(2025, 6, 1), new DateTime(2025, 6, 3)),
                new Prenotazione(2, 2, new DateTime(2025, 6, 5), new DateTime(2025, 6, 7)),
                new Prenotazione(3, 4, new DateTime(2025, 6, 10), new DateTime(2025, 6, 12)),
                new Prenotazione(1, 3, new DateTime(2025, 6, 15), new DateTime(2025, 6, 18))
            };
        }

        public static BindingList<Prenotazione> GetData()
        {
            if (prenotazioni.Count <= 0)
                prenotazioni = GetSampleData();
            return prenotazioni;
        }

        public static bool AggiungiPrenotazione(Prenotazione prenotazione)
        {
            if (CameraDisponibile(prenotazione.idCamera, prenotazione.dataArrivo, prenotazione.dataPartenza))
            {
                prenotazioni.Add(prenotazione);
                return true;
            }
            return false;
        }

        public static bool CameraDisponibile(int idCamera, DateTime dataArrivo, DateTime dataPartenza)
        {
            if (!CameraEsiste(idCamera))
                return false;

            for (int i = 0; i < prenotazioni.Count; i++)
            {
                if (prenotazioni[i].idCamera == idCamera)
                {
                    if (!(dataPartenza <= prenotazioni[i].dataArrivo || dataArrivo >= prenotazioni[i].dataPartenza))
                        return false;
                }
            }
            return true;
        }

        private static bool CameraEsiste(int idCamera)
        {
            BindingList<Camera> camere = Camera.GetData();
            for (int i = 0; i < camere.Count; i++)
            {
                if (camere[i].Id == idCamera)
                    return true;
            }
            return false;
        }

        private static bool ClienteEsiste(int idCliente)
        {
            BindingList<Cliente> clienti = Cliente.GetData();
            for (int i = 0; i < clienti.Count; i++)
            {
                if (clienti[i].Id == idCliente)
                    return true;
            }
            return false;
        }
    }
}