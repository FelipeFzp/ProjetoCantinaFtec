using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AplicacaoCantinaIUNIFTEC
{
    class Cadastro
    {
        public static List<string> ProdutosCadastrados = new List<string>(); //formatada em CSV (informações sao divididas com ; )

        public void CadastrarNovoProduto(string nome, string codigo, string preco, string dataFabricacao, string dataValidade)
        {
            float Preco=0f;
            float.TryParse(preco, out Preco);
            Produto produto = new Produto(nome,codigo,Preco,dataFabricacao,dataValidade);
            AdicionarProdutoLista(produto);
        }

        private void AdicionarProdutoLista(Produto produto)
        {
            ProdutosCadastrados.Add(produto.ToCSV());
        }

        public static bool ValidarCamposCadastroProdutos(string campoCodigo, string campoDataFabricacao, string campoNome, string campoPreco, string campoDataValidade)
        {
            float Preco = 0f;
            DateTime Fabricacao, Validade;
            // var Fabricacao = DateTime.Parse(campoDataFabricacao, CultureInfo.InvariantCulture).Date;
            // var Validade = DateTime.Parse(campoDataValidade, CultureInfo.CurrentCulture).Date;
            DateTime.TryParse(campoDataFabricacao, out Fabricacao);
            DateTime.TryParse(campoDataValidade, out Validade);

            if (campoCodigo != string.Empty && Fabricacao.Year <= Validade.Year &&
                Fabricacao.ToString() != "01/01/0001 00:00:00" && Validade.ToString() != "01/01/0001 00:00:00" &&
                campoNome != string.Empty && float.TryParse(campoPreco, out Preco))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void SalvarArquivoXML(string local)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode produtos = doc.CreateElement("PRODUTOS");
            XmlAttribute nome, codigo, preco, fabricacao, validade;
            string[] informacoes;
            foreach (var linha in ProdutosCadastrados)
            {
                informacoes = linha.Split(';');

                XmlNode produto = doc.CreateElement("PRODUTO");

                nome = doc.CreateAttribute("NOME");
                codigo = doc.CreateAttribute("CODIGO");
                preco = doc.CreateAttribute("PRECO");
                fabricacao = doc.CreateAttribute("FABRICACAO");
                validade = doc.CreateAttribute("VALIDADE");

                nome.Value = informacoes[0];
                codigo.Value = informacoes[1];
                preco.Value = informacoes[2];
                fabricacao.Value = informacoes[3];
                validade.Value = informacoes[4];

                produto.Attributes.Append(nome);
                produto.Attributes.Append(codigo);
                produto.Attributes.Append(preco);
                produto.Attributes.Append(fabricacao);
                produto.Attributes.Append(validade);

                produtos.AppendChild(produto);
            }
            doc.AppendChild(produtos);
            doc.Save(local);
        }
    }
}
