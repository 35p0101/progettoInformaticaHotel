using ClassLibraryHotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHotel
{
    public class GestoreHotel
    {
        private Amministratore utente;
        private BindingList<Attivita> attivita;
        private BindingList<Camera> camere;
        private BindingList<Cliente> clienti;
        private BindingList<Dipendente> dipendenti;
        private BindingList<Prenotazione> prenotazioni;

        public GestoreHotel(Amministratore utente)
        {
            this.utente = utente;
            attivita = Attivita.GetData();
            camere = Camera.GetData();
            clienti = Cliente.GetData();
            dipendenti = Dipendente.GetData();
            prenotazioni = Prenotazione.GetData();
        }

        public Amministratore Utente { get => utente; }
    }
}
