namespace AplicacaoCantinaIUNIFTEC
{
    partial class EditorProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorProdutos));
            this.ProdutosSelecionados_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CampoNome_textBox = new System.Windows.Forms.TextBox();
            this.CampoCodigo_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CampoPreco_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SalvarEdicao_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProdutosSelecionados_listBox
            // 
            this.ProdutosSelecionados_listBox.FormattingEnabled = true;
            this.ProdutosSelecionados_listBox.Location = new System.Drawing.Point(12, 32);
            this.ProdutosSelecionados_listBox.Name = "ProdutosSelecionados_listBox";
            this.ProdutosSelecionados_listBox.Size = new System.Drawing.Size(148, 264);
            this.ProdutosSelecionados_listBox.TabIndex = 2;
            this.ProdutosSelecionados_listBox.SelectedIndexChanged += new System.EventHandler(this.ProdutosSelecionados_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecionados para Edição:";
            // 
            // CampoNome_textBox
            // 
            this.CampoNome_textBox.Location = new System.Drawing.Point(49, 35);
            this.CampoNome_textBox.Name = "CampoNome_textBox";
            this.CampoNome_textBox.Size = new System.Drawing.Size(100, 20);
            this.CampoNome_textBox.TabIndex = 4;
            this.CampoNome_textBox.TextChanged += new System.EventHandler(this.CampoNome_textBox_TextChanged);
            // 
            // CampoCodigo_maskedTextBox
            // 
            this.CampoCodigo_maskedTextBox.Location = new System.Drawing.Point(49, 71);
            this.CampoCodigo_maskedTextBox.Mask = "0000";
            this.CampoCodigo_maskedTextBox.Name = "CampoCodigo_maskedTextBox";
            this.CampoCodigo_maskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CampoCodigo_maskedTextBox.TabIndex = 5;
            this.CampoCodigo_maskedTextBox.TextChanged += new System.EventHandler(this.CampoCodigo_maskedTextBox_TextChanged);
            // 
            // CampoPreco_textBox
            // 
            this.CampoPreco_textBox.Location = new System.Drawing.Point(49, 110);
            this.CampoPreco_textBox.Name = "CampoPreco_textBox";
            this.CampoPreco_textBox.Size = new System.Drawing.Size(100, 20);
            this.CampoPreco_textBox.TabIndex = 6;
            this.CampoPreco_textBox.TextChanged += new System.EventHandler(this.CampoPreco_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preço:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SalvarEdicao_button);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CampoNome_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CampoCodigo_maskedTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CampoPreco_textBox);
            this.groupBox1.Location = new System.Drawing.Point(168, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 182);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edição de Valores:";
            // 
            // SalvarEdicao_button
            // 
            this.SalvarEdicao_button.Location = new System.Drawing.Point(88, 153);
            this.SalvarEdicao_button.Name = "SalvarEdicao_button";
            this.SalvarEdicao_button.Size = new System.Drawing.Size(75, 23);
            this.SalvarEdicao_button.TabIndex = 10;
            this.SalvarEdicao_button.Text = "Salvar Item";
            this.SalvarEdicao_button.UseVisualStyleBackColor = true;
            this.SalvarEdicao_button.Click += new System.EventHandler(this.SalvarEdicao_button_Click);
            // 
            // EditorProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProdutosSelecionados_listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditorProdutos";
            this.Text = "EditorProdutoscs";
            this.Load += new System.EventHandler(this.EditorProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ProdutosSelecionados_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox CampoNome_textBox;
        public System.Windows.Forms.MaskedTextBox CampoCodigo_maskedTextBox;
        public System.Windows.Forms.TextBox CampoPreco_textBox;
        private System.Windows.Forms.Button SalvarEdicao_button;
    }
}