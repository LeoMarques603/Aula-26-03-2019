using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ItemNotaFiscal
    {
        public string CodigoProduto { get; set; }
        public int Preco { get; set; }
        public int Qtd { get; set; }
        public NotaFiscal NotaFiscal { get; set; }
        public int TotalItem { get; private set; }

        public ItemNotaFiscal(string codigoProduto, int preco, int qtd)
        {
            CodigoProduto = codigoProduto;
            Preco = preco;
            Qtd = qtd;
        }
    }
}
