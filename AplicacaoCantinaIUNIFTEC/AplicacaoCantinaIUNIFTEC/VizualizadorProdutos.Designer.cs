namespace AplicacaoCantinaIUNIFTEC
{
    partial class Opcoes_VizualizadorProdutos_form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opcoes_VizualizadorProdutos_form3));
            this.label2 = new System.Windows.Forms.Label();
            this.CampoBusca_textBox = new System.Windows.Forms.TextBox();
            this.Produtos_listView = new System.Windows.Forms.ListView();
            this.ColunaNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColunaCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColunaPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColunaFabricacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColunaValidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeletarItens_button = new System.Windows.Forms.Button();
            this.EditarItens_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar por:";
            // 
            // CampoBusca_textBox
            // 
            this.CampoBusca_textBox.Location = new System.Drawing.Point(73, 6);
            this.CampoBusca_textBox.Name = "CampoBusca_textBox";
            this.CampoBusca_textBox.Size = new System.Drawing.Size(100, 20);
            this.CampoBusca_textBox.TabIndex = 10;
            this.CampoBusca_textBox.TextChanged += new System.EventHandler(this.BuscarPor_TextBox_TextChanged);
            // 
            // Produtos_listView
            // 
            this.Produtos_listView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Produtos_listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Produtos_listView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Produtos_listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Produtos_listView.CheckBoxes = true;
            this.Produtos_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColunaNome,
            this.ColunaCodigo,
            this.ColunaPreco,
            this.ColunaFabricacao,
            this.ColunaValidade});
            this.Produtos_listView.FullRowSelect = true;
            this.Produtos_listView.GridLines = true;
            this.Produtos_listView.Location = new System.Drawing.Point(0, 32);
            this.Produtos_listView.Name = "Produtos_listView";
            this.Produtos_listView.Size = new System.Drawing.Size(498, 332);
            this.Produtos_listView.TabIndex = 11;
            this.Produtos_listView.TabStop = false;
            this.Produtos_listView.UseCompatibleStateImageBehavior = false;
            this.Produtos_listView.View = System.Windows.Forms.View.Details;
            // 
            // ColunaNome
            // 
            this.ColunaNome.Text = "Nome";
            this.ColunaNome.Width = 150;
            // 
            // ColunaCodigo
            // 
            this.ColunaCodigo.Text = "Código";
            this.ColunaCodigo.Width = 65;
            // 
            // ColunaPreco
            // 
            this.ColunaPreco.Text = "Preço";
            this.ColunaPreco.Width = 69;
            // 
            // ColunaFabricacao
            // 
            this.ColunaFabricacao.Text = "Data de Fabricação";
            this.ColunaFabricacao.Width = 109;
            // 
            // ColunaValidade
            // 
            this.ColunaValidade.Text = "Data de Validade";
            this.ColunaValidade.Width = 103;
            // 
            // DeletarItens_button
            // 
            this.DeletarItens_button.Location = new System.Drawing.Point(434, 6);
            this.DeletarItens_button.Name = "DeletarItens_button";
            this.DeletarItens_button.Size = new System.Drawing.Size(51, 20);
            this.DeletarItens_button.TabIndex = 12;
            this.DeletarItens_button.Text = "Deletar";
            this.DeletarItens_button.UseVisualStyleBackColor = true;
            this.DeletarItens_button.Click += new System.EventHandler(this.DeletarItens_button_Click);
            // 
            // EditarItens_button
            // 
            this.EditarItens_button.Location = new System.Drawing.Point(375, 6);
            this.EditarItens_button.Name = "EditarItens_button";
            this.EditarItens_button.Size = new System.Drawing.Size(53, 20);
            this.EditarItens_button.TabIndex = 13;
            this.EditarItens_button.Text = "Editar";
            this.EditarItens_button.UseVisualStyleBackColor = true;
            this.EditarItens_button.Click += new System.EventHandler(this.EditarItens_button_Click);
            // 
            // Opcoes_VizualizadorProdutos_form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(497, 362);
            this.Controls.Add(this.EditarItens_button);
            this.Controls.Add(this.DeletarItens_button);
            this.Controls.Add(this.Produtos_listView);
            this.Controls.Add(this.CampoBusca_textBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Opcoes_VizualizadorProdutos_form3";
            this.Text = "Produtos Cadastrados";
            this.TransparencyKey = System.Drawing.Color.LightSalmon;
            this.Load += new System.EventHandler(this.VizualizadorProdutos_form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CampoBusca_textBox;
        public System.Windows.Forms.ListView Produtos_listView;
        public System.Windows.Forms.ColumnHeader ColunaNome;
        public System.Windows.Forms.ColumnHeader ColunaCodigo;
        public System.Windows.Forms.ColumnHeader ColunaPreco;
        public System.Windows.Forms.ColumnHeader ColunaFabricacao;
        public System.Windows.Forms.ColumnHeader ColunaValidade;
        private System.Windows.Forms.Button DeletarItens_button;
        private System.Windows.Forms.Button EditarItens_button;
    }
}