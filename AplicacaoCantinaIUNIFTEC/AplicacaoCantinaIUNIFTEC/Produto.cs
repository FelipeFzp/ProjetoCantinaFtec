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
        public DateTime DataValidade { get; private set; }
        public DateTime DataFabricacao { get; private set; }

        public Produto(string nome, string codigo , float preco, DateTime dataFabricacao, DateTime dataValidade)
        {
            this.Nome = nome;
            this.Codigo = codigo;
            this.Preco = preco;
            this.DataFabricacao = dataFabricacao;
            this.DataValidade = dataValidade;
        }

        public override string ToString()
        {
            return $"Produto: {Nome}, Codigo: {Codigo}, Preço: {Preco}, Data de Fabricação: {DataFabricacao}, Data de Validade: {DataValidade}";
        }
    }
}
