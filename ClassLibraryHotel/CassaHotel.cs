using ClassLibraryHotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHotel
{
    public class CassaHotel
    {
        private static BindingList<CassaHotel> casse = new BindingList<CassaHotel>();
        private static int nextId = 1;

        private int id;
        private double totaleContanti;

        private Amministratore amministratore;
        private List<Transazione> transazioni;

        public CassaHotel(double totaleContanti)
        {
            id = nextId;
            nextId++;

            this.totaleContanti = totaleContanti;

            casse.Add(this);
        }
        public CassaHotel(double totaleContanti, Amministratore amministratore)
        {
            id = nextId;
            nextId++;

            this.totaleContanti = totaleContanti;
            this.amministratore = amministratore;

            casse.Add(this);
            transazioni = new List<Transazione>();
        }

        public int Id { get => id; }
        public double TotaleContanti { get => totaleContanti; set => totaleContanti = value; }
        public string NomeAmministratore
        {
            get
            {
                return Amministratore != null ? Amministratore.Nome : "";
            }
        }
        public Amministratore Amministratore
        {
            get => amministratore; set
            {
                if (amministratore.Equals(value)) return;
                amministratore = value;
            }
        }

        public void AddTransazione(Transazione t)
        {
            if (!transazioni.Contains(t))
            {
                transazioni.Add(t);
                t.Cassa = this;
            }
        }

        private static BindingList<CassaHotel> GetSampleData()
        {
            Amministratore a = (Amministratore)Dipendente.GetData().FirstOrDefault(dip => dip is Amministratore);
            return new BindingList<CassaHotel>
            {
                new CassaHotel(1000000, a),
                new CassaHotel(100000200, a),
                new CassaHotel(20000, a),
            };
        }
        public static BindingList<CassaHotel> GetData()
        {
            if (casse.Count <= 0) casse = GetSampleData();
            return casse;
        }
    }
}
