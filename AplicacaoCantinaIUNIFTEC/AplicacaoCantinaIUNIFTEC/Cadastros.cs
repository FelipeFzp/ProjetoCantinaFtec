using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoCantinaIUNIFTEC
{
    class Cadastro
    {
        public List<Produto> ProdutosCadastrados = new List<Produto>();

        public void CadastrarNovoProduto(string nome, string codigo, string preco, string dataFabricacao, string dataValidade)
        {
            float Preco=0f;
            float.TryParse(preco, out Preco);
            Produto produto = new Produto(nome,codigo,Preco,dataFabricacao,dataValidade);
            AdicionarProdutoLista(produto);
        }

        private void AdicionarProdutoLista(Produto produto)
        {
            ProdutosCadastrados.Add(produto);
        }
    }
}
