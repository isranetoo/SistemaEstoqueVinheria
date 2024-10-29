namespace SistemaEstoqueVinheria
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCarregarEstoque = new System.Windows.Forms.Button();
            this.btnSalvarEstoque = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCarregarEstoque
            // 
            this.btnCarregarEstoque.Location = new System.Drawing.Point(12, 12);
            this.btnCarregarEstoque.Name = "btnCarregarEstoque";
            this.btnCarregarEstoque.Size = new System.Drawing.Size(150, 30);
            this.btnCarregarEstoque.TabIndex = 0;
            this.btnCarregarEstoque.Text = "Carregar Estoque";
            this.btnCarregarEstoque.UseVisualStyleBackColor = true;
            this.btnCarregarEstoque.Click += new System.EventHandler(this.btnCarregarEstoque_Click);
            // 
            // btnSalvarEstoque
            // 
            this.btnSalvarEstoque.Location = new System.Drawing.Point(12, 48);
            this.btnSalvarEstoque.Name = "btnSalvarEstoque";
            this.btnSalvarEstoque.Size = new System.Drawing.Size(150, 30);
            this.btnSalvarEstoque.TabIndex = 1;
            this.btnSalvarEstoque.Text = "Salvar Estoque";
            this.btnSalvarEstoque.UseVisualStyleBackColor = true;
            this.btnSalvarEstoque.Click += new System.EventHandler(this.btnSalvarEstoque_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(12, 84);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(150, 30);
            this.btnAdicionarProduto.TabIndex = 2;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(120, 130);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(120, 158);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 4;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(120, 186);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 22);
            this.txtPreco.TabIndex = 5;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(120, 214);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 22);
            this.txtQuantidade.TabIndex = 6;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 133);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 17);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "ID:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 161);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 17);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(12, 189);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(47, 17);
            this.lblPreco.TabIndex = 9;
            this.lblPreco.Text = "Preço:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 217);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(81, 17);
            this.lblQuantidade.TabIndex = 10;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lstProdutos
            // 
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.ItemHeight = 16;
            this.lstProdutos.Location = new System.Drawing.Point(12, 250);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(400, 100);
            this.lstProdutos.TabIndex = 11;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.btnSalvarEstoque);
            this.Controls.Add(this.btnCarregarEstoque);
            this.Name = "Form1";
            this.Text = "Sistema de Estoque - Vinheria";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCarregarEstoque;
        private System.Windows.Forms.Button btnSalvarEstoque;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ListBox lstProdutos;
    }
}
