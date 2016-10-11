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
    public partial class VizualizadorProdutos_form3 : Form
    {
        public VizualizadorProdutos_form3()
        {
            InitializeComponent();
        }

        private void VizualizadorProdutos_form3_Load(object sender, EventArgs e)
        {
            string[] Informacoes;
            foreach (var linha in Cadastro.ProdutosCadastrados)
            {
                Informacoes = linha.Split(';');
                ListViewItem item = new ListViewItem(new[] { $"{Informacoes[0]}", $"{Informacoes[1]}", $"{Informacoes[2]} R$", $"{Informacoes[3]}",$"{Informacoes[4]}"});
                Produtos_listView.Items.Add(item);
            }
        }
    }
}
