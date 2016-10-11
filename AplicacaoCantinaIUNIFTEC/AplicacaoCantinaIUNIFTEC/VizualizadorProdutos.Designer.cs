namespace AplicacaoCantinaIUNIFTEC
{
    partial class VizualizadorProdutos_form3
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
            this.ColunaNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColunaCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColunaPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColunaFabricacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColunaValidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produtos_listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
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
            this.ColunaPreco.Width = 70;
            // 
            // ColunaFabricacao
            // 
            this.ColunaFabricacao.Text = "Data de Fabricação";
            this.ColunaFabricacao.Width = 109;
            // 
            // ColunaValidade
            // 
            this.ColunaValidade.Text = "Data de Validade";
            this.ColunaValidade.Width = 97;
            // 
            // Produtos_listView
            // 
            this.Produtos_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColunaNome,
            this.ColunaCodigo,
            this.ColunaPreco,
            this.ColunaFabricacao,
            this.ColunaValidade});
            this.Produtos_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Produtos_listView.Location = new System.Drawing.Point(0, 0);
            this.Produtos_listView.MultiSelect = false;
            this.Produtos_listView.Name = "Produtos_listView";
            this.Produtos_listView.Size = new System.Drawing.Size(495, 350);
            this.Produtos_listView.TabIndex = 0;
            this.Produtos_listView.UseCompatibleStateImageBehavior = false;
            this.Produtos_listView.View = System.Windows.Forms.View.Details;
            // 
            // VizualizadorProdutos_form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 350);
            this.Controls.Add(this.Produtos_listView);
            this.Name = "VizualizadorProdutos_form3";
            this.Text = "Produtos Cadastrados";
            this.Load += new System.EventHandler(this.VizualizadorProdutos_form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ColumnHeader ColunaNome;
        public System.Windows.Forms.ColumnHeader ColunaCodigo;
        public System.Windows.Forms.ColumnHeader ColunaPreco;
        public System.Windows.Forms.ColumnHeader ColunaFabricacao;
        public System.Windows.Forms.ColumnHeader ColunaValidade;
        private System.Windows.Forms.ListView Produtos_listView;
    }
}