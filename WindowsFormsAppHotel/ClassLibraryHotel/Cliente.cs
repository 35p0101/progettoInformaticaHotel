using ClassLibraryHotel;
using System.ComponentModel;

namespace ClassLibrary
{
    public class Cliente
    {
        private static BindingList<Cliente> clienti = new BindingList<Cliente>();
        private static int nextId = 1;

        private int id;
        private string nome;
        private string cognome;
        private string documento;

        private List<Transazione> transazioni;

        public Cliente(string nome, string cognome, string documento)
        {
            id = nextId;
            nextId++;

            this.nome = nome;
            this.cognome = cognome;
            this.documento = documento;

            clienti.Add(this);
            transazioni = new List<Transazione>();
        }

        public int Id { get => id; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public List<Transazione> Transazioni { get => transazioni; set => transazioni = value; }

        public void AddTransazione(Transazione t)
        {
            if (!transazioni.Contains(t))
            {
                transazioni.Add(t);
                t.Cliente = this;
            }
        }

        private static BindingList<Cliente> GetSampleData()
        {
            return new BindingList<Cliente>
            {
                new Cliente("c1", "C1","CA232QV"),
                new Cliente("c2", "C2", "CA126QF"),
                new Cliente("c3", "C3","JD396AS"),
                new Cliente("c4", "C4", "TU207ER"),
            };
        }
        public static BindingList<Cliente> GetData()
        {
            if (clienti.Count <= 0) clienti = GetSampleData();
            return clienti;
        }
    }
}
