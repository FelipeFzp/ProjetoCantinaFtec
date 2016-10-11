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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        #region Menu Opções

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opcoes_CadastrarProduto_Form2 form2 = new Opcoes_CadastrarProduto_Form2();
            form2.ShowDialog();
        }

        private void verProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VizualizadorProdutos_form3 form3 = new VizualizadorProdutos_form3();
            form3.ShowDialog();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salvarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
