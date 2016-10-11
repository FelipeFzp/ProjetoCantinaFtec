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
            ListViewItem nome = new ListViewItem();
            foreach(var linha in Cadastro.ProdutosCadastrados)
            {
                Informacoes = linha.Split(';');
                ColunaNome.ListView.Items.Add(Informacoes[0]);
                nome.Text = Informacoes[0];
                nome.SubItems.Add("teste");
                nome.SubItems.Add(Informacoes[2]);
                nome.SubItems.Add(Informacoes[3]);
                nome.SubItems.Add(Informacoes[4]);
            }
        }
    }
}
