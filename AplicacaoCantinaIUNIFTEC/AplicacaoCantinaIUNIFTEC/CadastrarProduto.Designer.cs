namespace AplicacaoCantinaIUNIFTEC
{
    partial class Opcoes_CadastrarProduto_Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opcoes_CadastrarProduto_Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CadastrarItem_button = new System.Windows.Forms.Button();
            this.CampoDataValidade_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CampoCodigo_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CampoPreco_textBox = new System.Windows.Forms.TextBox();
            this.CampoDataFabricacao_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CampoNome_textBox = new System.Windows.Forms.TextBox();
            this.Informacao_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Preço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data de Fabricação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Validade:";
            // 
            // CadastrarItem_button
            // 
            this.CadastrarItem_button.Enabled = false;
            this.CadastrarItem_button.Location = new System.Drawing.Point(116, 194);
            this.CadastrarItem_button.Name = "CadastrarItem_button";
            this.CadastrarItem_button.Size = new System.Drawing.Size(107, 23);
            this.CadastrarItem_button.TabIndex = 6;
            this.CadastrarItem_button.Text = "Inserir no Cadastro";
            this.CadastrarItem_button.UseVisualStyleBackColor = true;
            this.CadastrarItem_button.Click += new System.EventHandler(this.CadastrarItem_button_Click);
            // 
            // CampoDataValidade_maskedTextBox
            // 
            this.CampoDataValidade_maskedTextBox.Location = new System.Drawing.Point(123, 159);
            this.CampoDataValidade_maskedTextBox.Mask = "00/00/0000";
            this.CampoDataValidade_maskedTextBox.Name = "CampoDataValidade_maskedTextBox";
            this.CampoDataValidade_maskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CampoDataValidade_maskedTextBox.TabIndex = 4;
            this.CampoDataValidade_maskedTextBox.ValidatingType = typeof(System.DateTime);
            this.CampoDataValidade_maskedTextBox.TextChanged += new System.EventHandler(this.CampoDataValidade_maskedTextBox_TextChanged);
            // 
            // CampoCodigo_maskedTextBox
            // 
            this.CampoCodigo_maskedTextBox.Location = new System.Drawing.Point(123, 46);
            this.CampoCodigo_maskedTextBox.Mask = "0000";
            this.CampoCodigo_maskedTextBox.Name = "CampoCodigo_maskedTextBox";
            this.CampoCodigo_maskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CampoCodigo_maskedTextBox.TabIndex = 1;
            this.CampoCodigo_maskedTextBox.TextChanged += new System.EventHandler(this.CampoCodigo_maskedTextBox_TextChanged);
            // 
            // CampoPreco_textBox
            // 
            this.CampoPreco_textBox.Location = new System.Drawing.Point(123, 85);
            this.CampoPreco_textBox.Name = "CampoPreco_textBox";
            this.CampoPreco_textBox.Size = new System.Drawing.Size(100, 20);
            this.CampoPreco_textBox.TabIndex = 2;
            this.CampoPreco_textBox.TextChanged += new System.EventHandler(this.CampoPreco_textBox_TextChanged);
            // 
            // CampoDataFabricacao_maskedTextBox
            // 
            this.CampoDataFabricacao_maskedTextBox.Location = new System.Drawing.Point(123, 120);
            this.CampoDataFabricacao_maskedTextBox.Mask = "00/00/0000";
            this.CampoDataFabricacao_maskedTextBox.Name = "CampoDataFabricacao_maskedTextBox";
            this.CampoDataFabricacao_maskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CampoDataFabricacao_maskedTextBox.TabIndex = 3;
            this.CampoDataFabricacao_maskedTextBox.ValidatingType = typeof(System.DateTime);
            this.CampoDataFabricacao_maskedTextBox.TextChanged += new System.EventHandler(this.CampoDataFabricacao_maskedTextBox_TextChanged);
            // 
            // CampoNome_textBox
            // 
            this.CampoNome_textBox.Location = new System.Drawing.Point(123, 15);
            this.CampoNome_textBox.Name = "CampoNome_textBox";
            this.CampoNome_textBox.Size = new System.Drawing.Size(100, 20);
            this.CampoNome_textBox.TabIndex = 0;
            this.CampoNome_textBox.TextChanged += new System.EventHandler(this.CampoNome_textBox_TextChanged);
            // 
            // Informacao_label
            // 
            this.Informacao_label.AutoSize = true;
            this.Informacao_label.Location = new System.Drawing.Point(3, 199);
            this.Informacao_label.Name = "Informacao_label";
            this.Informacao_label.Size = new System.Drawing.Size(88, 13);
            this.Informacao_label.TabIndex = 11;
            this.Informacao_label.Text = "Informacao_label";
            // 
            // Opcoes_CadastrarProduto_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(256, 230);
            this.Controls.Add(this.Informacao_label);
            this.Controls.Add(this.CampoDataFabricacao_maskedTextBox);
            this.Controls.Add(this.CampoNome_textBox);
            this.Controls.Add(this.CampoPreco_textBox);
            this.Controls.Add(this.CampoCodigo_maskedTextBox);
            this.Controls.Add(this.CampoDataValidade_maskedTextBox);
            this.Controls.Add(this.CadastrarItem_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Opcoes_CadastrarProduto_Form2";
            this.Text = "Cadastrar Novo Produto";
            this.Load += new System.EventHandler(this.Opcoes_CadastrarProduto_Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CadastrarItem_button;
        private System.Windows.Forms.MaskedTextBox CampoDataValidade_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox CampoCodigo_maskedTextBox;
        private System.Windows.Forms.TextBox CampoPreco_textBox;
        private System.Windows.Forms.MaskedTextBox CampoDataFabricacao_maskedTextBox;
        private System.Windows.Forms.TextBox CampoNome_textBox;
        private System.Windows.Forms.Label Informacao_label;
    }
}