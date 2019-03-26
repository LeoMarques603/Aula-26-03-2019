using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NotaFiscal
    {
        public string CodigoCliente { get; set; }
        public int ICMS { get; private set; }
        public int TotalNota { get; private set; }
        List<ItemNotaFiscal> Items { get; set; }

        public void Inclusao(string codigoProduto, int preco, int qtd)
        {
            ItemNotaFiscal inf = new ItemNotaFiscal(codigoProduto, preco, qtd);
            Items.Add(inf);
        }

        public decimal CalculoICMS
        {
           get
            {
                decimal valorICMS = 0;

                foreach (ItemNotaFiscal inf in Items)
                {
                    decimal valorICMS = 0;
                    valorICMS = TotalNota / 4;
                    
                }
                return valorICMS
            }
        }
    }
}
