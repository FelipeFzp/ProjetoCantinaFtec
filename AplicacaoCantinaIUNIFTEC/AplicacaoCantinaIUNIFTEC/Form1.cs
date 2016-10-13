using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        #region Menu Opções
        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opcoes_CadastrarProduto_Form2 form2 = new Opcoes_CadastrarProduto_Form2();
            form2.ShowDialog();
        }

        private void verProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opcoes_VizualizadorProdutos_form3 form3 = new Opcoes_VizualizadorProdutos_form3();
            form3.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salvarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarArquivo_saveFileDialog.DefaultExt = ".xml";
            SalvarArquivo_saveFileDialog.Filter = "Arquivos XML | *.xml";
            SalvarArquivo_saveFileDialog.Title = "Selecione um local para salvar seu arquivo";
            DialogResult resultadoJanela = SalvarArquivo_saveFileDialog.ShowDialog();
            var local = SalvarArquivo_saveFileDialog.FileName;
            var extensao = Path.GetExtension(local);
            if (extensao.Equals(".xml") && resultadoJanela.Equals(DialogResult.OK))
            {
                Cadastro.SalvarArquivoXML(local);
            }
        }


        private void abrirArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            AbrirArquivo_openFileDialog.Filter = "Arquivos XML | *.xml";
            AbrirArquivo_openFileDialog.Title = "Selecione um local para abrir seu arquivo";
            DialogResult resultadoJanela = AbrirArquivo_openFileDialog.ShowDialog();
            var local = AbrirArquivo_openFileDialog.FileName;
            cadastro.AbrirArquivoXML(local);
        }
        #endregion

    }
}
