using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AplicacaoCantinaIUNIFTEC
{
    class Cadastro
    {
        public static List<string> ProdutosCadastrados = new List<string>(); //Listas formatadas em CSV (informações sao divididas com ; )
        private static List<Produto> ProdutosCadastrados_Objetoxxxxxxas = new List<Produto>();

        #region Cadastro e Manipulação de Produtos
        public void CadastrarNovoProduto(string nome, string codigo, string preco, string dataFabricacao, string dataValidade)
        {
            float Preco = 0f;
            float.TryParse(preco, out Preco);
            Produto produto = new Produto(nome, codigo, Preco, dataFabricacao, dataValidade);
            AdicionarProdutoLista(produto);
        }

        private void AdicionarProdutoLista(Produto produto)
        {
            ProdutosCadastrados.Add(produto.ToCSV());
            ProdutosCadastrados_Objetos.Add(produto);
        }

        public void DeletarItens(ListView.CheckedListViewItemCollection ItensSelecionados)
        {
            List<string> ItensFormatados = FormatarItens(ItensSelecionados);
            if (ItensFormatados!=null)
            foreach (var item in ItensFormatados)
            {    
                var ProdutoParaRemover = ProdutosCadastrados_Objetos.Where(produto => produto.Nome.Equals(item));
                for (int i = 0; i < ProdutoParaRemover.Count(); i++)
                {
                    ProdutosCadastrados.Remove(ProdutoParaRemover.ElementAt(i).ToCSV());
                    ProdutosCadastrados_Objetos.Remove(ProdutoParaRemover.ElementAt(i));
                }
            }
        }

        public void EditarItens(ListView.CheckedListViewItemCollection ItensSelecionados)
        {
            FormatarItens(ItensSelecionados);
            

        }

        private List<string> FormatarItens(ListView.CheckedListViewItemCollection ItensSelecionados)
        {
            List<string> ItensFormatados = new List<string>();
            List<char> texto = new List<char>();
            foreach (var item in ItensSelecionados)
            {
                char[] formatacao = item.ToString().ToCharArray();
                for (int i = 15; i != formatacao.Length - 1; i++)
                {
                    texto.Add(formatacao.ElementAt(i));
                }
                ItensFormatados.Add(new string(texto.ToArray()));
            }
            return ItensFormatados;
        }
        //fazer metodo formatar itens de listviewitemcollection para lista string e usar no deletar e editar em vez de repetir o codigo em cada metodo
        #endregion

        #region Validação dos Campos
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
        #endregion

        #region Manipulação Arquivos
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

        public void AbrirArquivoXML(string local)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(local);
            string nome = "", codigo = "", preco = "", fabricacao = "", validade = "";
            ProdutosCadastrados.Clear();
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlAttribute attr in node.Attributes)
                {
                    switch (attr.Name)
                    {
                        case "NOME":
                            nome = attr.Value;
                            break;
                        case "CODIGO":
                            codigo = attr.Value;
                            break;
                        case "PRECO":
                            preco = attr.Value;
                            break;
                        case "FABRICACAO":
                            fabricacao = attr.Value;
                            break;
                        case "VALIDADE":
                            validade = attr.Value;
                            break;
                    }
                }
                CadastrarNovoProduto(nome, codigo, preco, fabricacao, validade);
            }
        }
        #endregion

        #region Filtro Lista de Produtos Cadastrados
        public static List<string> FiltrarListaProdutosCadastrados(string parametroFiltro)
        {
            List<string> ListaFiltrada = new List<string>();
            var InformacoesFiltradas = ProdutosCadastrados.Where(produto => produto.Contains(parametroFiltro));
            foreach (var informacao in InformacoesFiltradas)
            {
                ListaFiltrada.Add(informacao);
            }
            return ListaFiltrada;
        }
        #endregion


    }
}
