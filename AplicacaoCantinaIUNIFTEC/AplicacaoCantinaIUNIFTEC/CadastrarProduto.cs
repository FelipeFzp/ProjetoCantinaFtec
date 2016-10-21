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
    public partial class Opcoes_CadastrarProduto_Form2 : Form
    {
        public Opcoes_CadastrarProduto_Form2()
        {
            InitializeComponent();
        }

        private void CadastrarItem_button_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.CadastrarNovoProduto(CampoNome_textBox.Text,CampoCodigo_maskedTextBox.Text,CampoPreco_textBox.Text,CampoDataFabricacao_maskedTextBox.Text,CampoDataValidade_maskedTextBox.Text);
            MessageBox.Show("Produto cadastrado com sucesso !", "Produto adicionado ao cadastro.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void CampoNome_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Cadastro.ValidarCamposCadastroProdutos(CampoCodigo_maskedTextBox.Text, CampoDataFabricacao_maskedTextBox.Text, CampoNome_textBox.Text, CampoPreco_textBox.Text, CampoDataValidade_maskedTextBox.Text))
            {
                CadastrarItem_button.Enabled = true;
                Informacao_label.Text = " ";
            }
            else
            {
                CadastrarItem_button.Enabled = false;
                Informacao_label.Text = "Campos Inválidos";
            }
        }

        private void CampoPreco_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Cadastro.ValidarCamposCadastroProdutos(CampoCodigo_maskedTextBox.Text, CampoDataFabricacao_maskedTextBox.Text, CampoNome_textBox.Text, CampoPreco_textBox.Text, CampoDataValidade_maskedTextBox.Text))
            {
                CadastrarItem_button.Enabled = true;
                Informacao_label.Text = " ";
            }
            else
            {
                CadastrarItem_button.Enabled = false;
                Informacao_label.Text = "Campos Inválidos";
            }
        }

        private void Opcoes_CadastrarProduto_Form2_Load(object sender, EventArgs e)
        {
            Informacao_label.ForeColor = Color.Red;
            Informacao_label.Text = "Preencha os Campos.";
        }

        private void CampoDataFabricacao_maskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Cadastro.ValidarCamposCadastroProdutos(CampoCodigo_maskedTextBox.Text, CampoDataFabricacao_maskedTextBox.Text, CampoNome_textBox.Text, CampoPreco_textBox.Text, CampoDataValidade_maskedTextBox.Text))
            {
                CadastrarItem_button.Enabled = true;
                Informacao_label.Text = " ";
            }
            else
            {
                CadastrarItem_button.Enabled = false;
                Informacao_label.Text = "Campos Inválidos";
            }
        }

        private void CampoCodigo_maskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Cadastro.ValidarCamposCadastroProdutos(CampoCodigo_maskedTextBox.Text, CampoDataFabricacao_maskedTextBox.Text, CampoNome_textBox.Text, CampoPreco_textBox.Text, CampoDataValidade_maskedTextBox.Text))
            {
                CadastrarItem_button.Enabled = true;
                Informacao_label.Text = " ";
            }
            else
            {
                CadastrarItem_button.Enabled = false;
                Informacao_label.Text = "Campos Inválidos";
            }
        }

        private void CampoDataValidade_maskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Cadastro.ValidarCamposCadastroProdutos(CampoCodigo_maskedTextBox.Text, CampoDataFabricacao_maskedTextBox.Text, CampoNome_textBox.Text, CampoPreco_textBox.Text, CampoDataValidade_maskedTextBox.Text))
            {
                CadastrarItem_button.Enabled = true;
                Informacao_label.Text = " ";
            }
            else
            {
                CadastrarItem_button.Enabled = false;
                Informacao_label.Text = "Campos Inválidos";
            }
        }
    }
}
