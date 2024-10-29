using System;
using System.Windows.Forms;

namespace SistemaEstoqueVinheria
{
    public partial class Form1 : Form
    {
        private Estoque estoque;

        public Form1()
        {
            InitializeComponent();
            estoque = new Estoque();
            estoque.CarregarEstoque(); // Carrega o estoque ao iniciar o formulário
            AtualizarListaProdutos();   // Atualiza a lista de produtos ao iniciar
        }

        private void btnCarregarEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                estoque.CarregarEstoque();
                AtualizarListaProdutos();
                MessageBox.Show("Estoque carregado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar estoque: {ex.Message}");
            }
        }

        private void btnSalvarEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                estoque.SalvarEstoque();
                MessageBox.Show("Estoque salvo com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar estoque: {ex.Message}");
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id) &&
                double.TryParse(txtPreco.Text, out double preco) &&
                int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                string nome = txtNome.Text;
                Produto produto = new Produto(id, nome, preco, quantidade);
                estoque.AdicionarProduto(produto);
                AtualizarListaProdutos(); // Atualiza a lista após adicionar o produto

                // Salvar automaticamente após adicionar o produto
                try
                {
                    estoque.SalvarEstoque();
                    MessageBox.Show("Produto adicionado e estoque salvo automaticamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar o estoque: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos.");
            }
        }

        private void AtualizarListaProdutos()
        {
            lstProdutos.Items.Clear(); // Limpa a lista atual
            foreach (var produto in estoque.Produtos) // Acesse a lista de produtos na classe Estoque
            {
                lstProdutos.Items.Add(produto.ToString());
            }
        }
    }
}
