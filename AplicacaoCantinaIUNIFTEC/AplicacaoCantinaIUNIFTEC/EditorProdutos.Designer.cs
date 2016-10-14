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
            this.ProdutosSelecionados_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProdutosSelecionados_listBox
            // 
            this.ProdutosSelecionados_listBox.FormattingEnabled = true;
            this.ProdutosSelecionados_listBox.Location = new System.Drawing.Point(12, 25);
            this.ProdutosSelecionados_listBox.Name = "ProdutosSelecionados_listBox";
            this.ProdutosSelecionados_listBox.Size = new System.Drawing.Size(148, 277);
            this.ProdutosSelecionados_listBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecionados para Edição:";
            // 
            // EditorProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProdutosSelecionados_listBox);
            this.Name = "EditorProdutos";
            this.Text = "EditorProdutoscs";
            this.Load += new System.EventHandler(this.EditorProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ProdutosSelecionados_listBox;
        private System.Windows.Forms.Label label1;
    }
}