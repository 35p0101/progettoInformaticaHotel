using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryHotel;

namespace ClassLibraryHotel
{
    public class Attivita
    {
        private string tipoAttivita;
        private DateTime dataOraPrenotazione;
        private int idCliente;
        //private int idDipendente;

        public Attivita(string tipoAttivita, DateTime dataOraPrenotazione, int idCliente)
        {
            this.tipoAttivita = tipoAttivita;
            this.dataOraPrenotazione = dataOraPrenotazione;
            this.idCliente = idCliente;
        }

        public string TipoAttivita { get => tipoAttivita; set => tipoAttivita = value; }
        public DateTime DataOraPrenotazione { get => dataOraPrenotazione; set => dataOraPrenotazione = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }

    }
}
