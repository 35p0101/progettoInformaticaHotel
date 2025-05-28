using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryHotel;

namespace ClassLibraryHotel
{
    public class Attivita
    {
        private static BindingList<Attivita> attivita = new BindingList<Attivita>();

        private string tipoAttivita;
        private DateTime dataPrenotazione;
        private int idCliente;

        public Attivita(string tipoAttivita, DateTime dataPrenotazione, int idCliente)
        {
            this.tipoAttivita = tipoAttivita;
            this.dataPrenotazione = dataPrenotazione;
            this.idCliente = idCliente;
        }

        public string TipoAttivita { get => tipoAttivita; set => tipoAttivita = value; }
        public DateTime DataPrenotazione { get => dataPrenotazione; set => dataPrenotazione = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }

        private static BindingList<Attivita> GetSampleData()
        {
            return new BindingList<Attivita>
            {
                new Attivita("Spa",new DateTime(2025,6,1),1),
                new Attivita("Ristorante",new DateTime(2025,6,2),1),
                new Attivita("Noleggio Auto",new DateTime(2025,6,1),2),
                new Attivita("Escursione",new DateTime(2025,6,1),2)

            };
        }

        public static BindingList<Attivita> GetData() 
        {
            if (attivita.Count <= 0) attivita = GetSampleData();
            return attivita;
        }
    }
}
