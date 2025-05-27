using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryHotel;

namespace ClassLibraryHotel
{
    public class Turno
    {
        private DateTime dataInizio;
        private DateTime dataFine;

        public Turno(DateTime dataInizio, DateTime dataFine)
        {
            this.dataInizio = dataInizio;
            this.dataFine = dataFine;
        }

        public DateTime DataInizio { get => dataInizio; set => dataInizio = value; }
        public DateTime DataFine { get => dataFine; set => dataFine = value; }
    }
}
