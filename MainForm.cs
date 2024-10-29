using System;
using System.Windows.Forms;

namespace EstoqueApp
{
    public class EstoqueForm : Form
    {
        private Estoque estoque = new Estoque();
        private TextBox txtId, txtNome, txtPreco, txtQuantidade;
        private ListBox listBoxProdutos;
        private Panel panelBotoes;
        private FlowLayoutPanel panelInputs;

        public EstoqueForm()
        {
            // Configuração inicial da janela
            this.Text = "Gerenciador de Estoque";
            this.Width = 800;
            this.Height = 600;
            this.StartPosition = FormStartPosition.CenterScreen;

            InicializarControles();

            // Carrega e exibe produtos ao iniciar o programa
            estoque.CarregarEstoque();
            ExibirProdutos();
        }

        private void InicializarControles()
        {
            // Configura um painel para os inputs com layout horizontal
            panelInputs = new FlowLayoutPanel()
            {
                Dock = DockStyle.Top,
                Height = 120, // Aumentando a altura do painel dos inputs
                Padding = new Padding(10),
                AutoSize = true,
                WrapContents = false,
                FlowDirection = FlowDirection.LeftToRight
            };

            // Criação e configuração dos campos de entrada com tamanho reduzido
            txtId = CriarInputComLabel("ID", 60); // Largura reduzida
            txtNome = CriarInputComLabel("Nome", 160); // Largura reduzida
            txtPreco = CriarInputComLabel("Preço", 60); // Largura reduzida
            txtQuantidade = CriarInputComLabel("Quantidade", 60); // Largura reduzida

             // Painel para o ListBox para adicionar espaço
            var panelListBox = new Panel()
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(10, 70, 10, 0) // Padding apenas para o topo
            };

            // ListBox para exibir os produtos
            listBoxProdutos = new ListBox() 
            { 
                Dock = DockStyle.Fill, 
                Margin = new Padding(0, 40, 0, 0) // Aumentando a margem superior para 40 pixels
            };

            panelListBox.Controls.Add(listBoxProdutos);

            // Painel para os botões
            panelBotoes = new Panel() 
            { 
                Dock = DockStyle.Bottom, 
                Height = 50, 
                Padding = new Padding(10) 
            };

            var btnAdicionarProduto = new Button() { Text = "Adicionar Produto", Dock = DockStyle.Left, Width = 150 };
            btnAdicionarProduto.Click += (sender, e) => AdicionarProduto();

            var btnSalvarEstoque = new Button() { Text = "Salvar Estoque", Dock = DockStyle.Left, Width = 150 };
            btnSalvarEstoque.Click += (sender, e) => estoque.SalvarEstoque();

            // Adiciona os botões ao painel
            panelBotoes.Controls.Add(btnSalvarEstoque);
            panelBotoes.Controls.Add(btnAdicionarProduto);

            // Adiciona os inputs e o ListBox à forma
            Controls.Add(panelInputs);
            Controls.Add(panelListBox);
            Controls.Add(panelBotoes);
        }

        private TextBox CriarInputComLabel(string labelText, int width)
        {
            var panel = new FlowLayoutPanel()
            {
                Width = width + 20,
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                Margin = new Padding(5) // Adiciona espaço entre os inputs
            };

            var label = new Label() { Text = labelText, AutoSize = true };
            var textBox = new TextBox() { Width = width };

            panel.Controls.Add(label);
            panel.Controls.Add(textBox);

            panelInputs.Controls.Add(panel);
            return textBox;
        }

        private void AdicionarProduto()
        {
            if (int.TryParse(txtId.Text, out int id) &&
                double.TryParse(txtPreco.Text, out double preco) &&
                int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                var produto = new Produto(id, txtNome.Text, preco, quantidade);
                estoque.AdicionarProduto(produto);
                ExibirProdutos();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos.");
            }
        }

        private void ExibirProdutos()
        {
            listBoxProdutos.Items.Clear();
            foreach (var produto in estoque.Produtos)
            {
                listBoxProdutos.Items.Add(produto.ToString());
            }
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EstoqueForm());
        }
    }
}
