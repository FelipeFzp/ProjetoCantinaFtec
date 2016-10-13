using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoCantinaIUNIFTEC
{
    public partial class Opcoes_VizualizadorProdutos_form3 : Form
    {
        public Opcoes_VizualizadorProdutos_form3()
        {
            InitializeComponent();
        }

        private void VizualizadorProdutos_form3_Load(object sender, EventArgs e)
        {
            AtualizarListView(Cadastro.ProdutosCadastrados);
        }

        private void BuscarPor_TextBox_TextChanged(object sender, EventArgs e)
        {
            List<string> ListaFiltrada = Cadastro.FiltrarListaProdutosCadastrados(CampoBusca_textBox.Text);
            AtualizarListView(ListaFiltrada);
        }

        private void AtualizarListView(List<string> Lista)
        {
            string[] Informacoes;
            Produtos_listView.Items.Clear();
            foreach (var linha in Lista)
            {
                Informacoes = linha.Split(';');
                ListViewItem item = new ListViewItem(new[] { $"{Informacoes[0]}", $"{Informacoes[1]}", $"{Informacoes[2]} R$", $"{Informacoes[3]}", $"{Informacoes[4]}" });
                Produtos_listView.Items.Add(item);
            }
        }
    }
}
