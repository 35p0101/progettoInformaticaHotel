using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryHotel;

namespace ClassLibraryHotel
{
    public class Amministratore: Dipendente
    {
        private string username;
        private string passwordHash;

        public Amministratore(string nome, string cognome, int stipendio, string username, string passwordHash) : base(nome, cognome, stipendio)
        {
            this.username = username;
            this.passwordHash = passwordHash;
        }

        public string Username { get => username; set => username = value; }
        public string PasswordHash { get => passwordHash; set => passwordHash = value; }

        public bool Login(string username, string passwordHash)
        {
            return this.username == username && this.passwordHash == passwordHash;
        }
    }
}
