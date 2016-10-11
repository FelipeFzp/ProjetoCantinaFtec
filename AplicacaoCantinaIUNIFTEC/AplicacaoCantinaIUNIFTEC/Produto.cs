using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoCantinaIUNIFTEC
{
    class Produto
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public float  Preco { get; private set; }
        public string DataValidade { get; private set; }
        public string DataFabricacao { get; private set; }

        public Produto(string nome, string codigo , float preco, string dataFabricacao, string dataValidade)
        {
            this.Nome = nome;
            this.Codigo = codigo;
            this.Preco = preco;
            this.DataFabricacao = dataFabricacao;
            this.DataValidade = dataValidade;
        }
        
        public string ToCSV()
        {
            return $"{Nome};{Codigo};{Preco};{DataFabricacao};{DataValidade}";
        }
    }
}
