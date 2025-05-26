using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHotel
{
    public class Transazione
    {
        private string tipoPagamento;
        private double importo;
        private DateTime data;
        private string metodoPagamento;

        private Cliente cliente;

        public Transazione(string tipoPagamento, double importo, DateTime data, string metodoPagamento)
        {
            this.tipoPagamento = tipoPagamento;
            this.importo = importo;
            this.data = data;
            this.metodoPagamento = metodoPagamento;
        }

        public Transazione(string tipoPagamento, double importo, DateTime data, string metodoPagamento, Cliente cliente)
        {
            this.tipoPagamento = tipoPagamento;
            this.importo = importo;
            this.data = data;
            this.metodoPagamento = metodoPagamento;
            this.cliente = cliente;
        }

        public string TipoPagamento { get => tipoPagamento; set => tipoPagamento = value; }
        public double Importo { get => importo; set => importo = value; }
        public DateTime Data { get => data; set => data = value; }
        public string MetodoPagamento { get => metodoPagamento; set => metodoPagamento = value; }

        public Cliente Cliente
        {
            get => cliente; set
            {
                if (cliente.Equals(value)) return;
                cliente = value;
            }
        }


    }
}
