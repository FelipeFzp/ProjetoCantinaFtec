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
    public partial class EditorProdutos : Form
    {
        public EditorProdutos()
        {
            InitializeComponent();
        }
        public List<string> ItensSelecionadosFormatados = new List<string>();

        private void EditorProdutos_Load(object sender, EventArgs e)
        {
            foreach (var item in ItensSelecionadosFormatados)
                ProdutosSelecionados_listBox.Items.Add(item);
        }

        private void ProdutosSelecionados_SelectedIndexChanged(object sender, EventArgs e)
        {
            CampoCodigo_maskedTextBox.ResetText();
            CampoNome_textBox.ResetText();
            CampoPreco_textBox.ResetText();
            Cadastro cadastro = new Cadastro();
            var ItemSelecionado = ProdutosSelecionados_listBox.SelectedItem;
            Produto produto = cadastro.BuscarProdutoEditor(ItemSelecionado);
            if (produto!=null)
            {
                CampoCodigo_maskedTextBox.Text = produto.Codigo;
                CampoNome_textBox.Text = produto.Nome;
                CampoPreco_textBox.Text = String.Format("{0:0.00}", produto.Preco);
            } 
        }

        private void CampoNome_textBox_TextChanged(object sender, EventArgs e)
        {
            SalvarEdicao_button.Enabled = Cadastro.ValidarCamposEditor(CampoCodigo_maskedTextBox.Text, CampoNome_textBox.Text, CampoPreco_textBox.Text);
        }

        private void CampoPreco_textBox_TextChanged(object sender, EventArgs e)
        {
            SalvarEdicao_button.Enabled = Cadastro.ValidarCamposEditor(CampoCodigo_maskedTextBox.Text, CampoNome_textBox.Text, CampoPreco_textBox.Text);
        }

        private void CampoCodigo_maskedTextBox_TextChanged(object sender, EventArgs e)
        {
            SalvarEdicao_button.Enabled = Cadastro.ValidarCamposEditor(CampoCodigo_maskedTextBox.Text, CampoNome_textBox.Text, CampoPreco_textBox.Text);
        }

        private void SalvarEdicao_button_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            var ItemSelecionado = ProdutosSelecionados_listBox.SelectedItem;
            int IndexItem = Cadastro.ProdutosCadastrados.FindIndex(p => p.Contains(ItemSelecionado.ToString()));
            Produto produtoCompleto = cadastro.AlterarProduto(CampoNome_textBox.Text, CampoCodigo_maskedTextBox.Text, CampoPreco_textBox.Text, IndexItem);
            cadastro.InserirProdutoEditado(produtoCompleto, IndexItem);
            ProdutosSelecionados_listBox.Items.Remove(produtoCompleto.Nome);
            if (ProdutosSelecionados_listBox.Items.Count == 0)
                Close();
        }
    }
}
