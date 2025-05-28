using ClassLibraryHotel;
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

        private CassaHotel cassa;
        private Cliente cliente;

        public Transazione(string tipoPagamento, double importo, DateTime data, string metodoPagamento)
        {
            this.tipoPagamento = tipoPagamento;
            this.importo = importo;
            this.data = data;
            this.metodoPagamento = metodoPagamento;

            cassa = null;
            cliente = null;
        }

        public Transazione(string tipoPagamento, double importo, DateTime data, string metodoPagamento, CassaHotel cassa, Cliente cliente)
        {
            this.tipoPagamento = tipoPagamento;
            this.importo = importo;
            this.data = data;
            this.metodoPagamento = metodoPagamento;
            this.cassa = cassa;
            this.cliente = cliente;
        }

        public string TipoPagamento { get => tipoPagamento; set => tipoPagamento = value; }
        public double Importo { get => importo; set => importo = value; }
        public DateTime Data { get => data; set => data = value; }
        public string MetodoPagamento { get => metodoPagamento; set => metodoPagamento = value; }
        public CassaHotel Cassa
        {
            get => cassa; set
            {
                if (cassa.Equals(value)) return;
                cassa = value;
            }
        }
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
