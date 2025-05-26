using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Dipendente
    {
        private static BindingList<Dipendente> dipendenti = new BindingList<Dipendente>();

        private string nome;
        private string cognome;
        private int stipendio;

        public Dipendente(string nome, string cognome, int stipendio)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.stipendio = stipendio;

            dipendenti.Add(this);
            //turni = new List<Turno>();
        }
        //public Dipendente(string nome, string cognome, int stipendio, List<Turno> turni)
        //{
        //    this.nome = nome;
        //    this.cognome = cognome;
        //    this.stipendio = stipendio;

        //    dipendenti.Add(this);
        //    this.turni = turni;
        //}

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public int Stipendio { get => stipendio; set => stipendio = value; }

        //public void AddTurno(Turno t)
        //{
        //    if (!turni.Contains(t)) turni.Add(t);
        //}
        private static BindingList<Dipendente> GetSampleData()
        {
            return new BindingList<Dipendente>
            {
                new Amministratore("Cadel", "Pippo", 10000, "admin", "hash32"),
                new Dipendente("Cadel", "Evans", 2000),
                new Dipendente("ledaC", "snavE", 1200),
                new Dipendente("Pippo", "Pippo", 2000),
                new Dipendente("Jack", "Go", 1600)
            };
        }
        public static BindingList<Dipendente> GetData()
        {
            if (dipendenti.Count <= 0) dipendenti = GetSampleData();
            return dipendenti;
        }
    }
}
