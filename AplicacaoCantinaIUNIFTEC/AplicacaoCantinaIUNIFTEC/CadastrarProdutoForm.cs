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

        private void Validar_button_Click(object sender, EventArgs e)
        {
            if (Cadastro.ValidarCamposCadastroProdutos(CampoCodigo_maskedTextBox.Text, CampoDataFabricacao_maskedTextBox.Text, CampoNome_textBox.Text, CampoPreco_textBox.Text, CampoDataValidade_maskedTextBox.Text))
            {
                CadastrarItem_button.Enabled = true;
            }
            else
            {
                CadastrarItem_button.Enabled = false;
                MessageBox.Show("Preenchimento dos campos estão Inválidos !", "Campos estão vazios/Preço Inválido/Datas Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
