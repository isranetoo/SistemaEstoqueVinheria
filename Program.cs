using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(int id, string nome, double preco, int quantidade)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Nome: {Nome}, Preço: R${Preco:F2}, Quantidade: {Quantidade}";
    }
}

public class Estoque
{
    private List<Produto> produtos = new List<Produto>();
    private const string arquivoEstoque = "estoque.txt";

    public List<Produto> Produtos => produtos;

    public void AdicionarProduto(Produto produto)
    {
        if (BuscarProdutoPorId(produto.Id) == null)
        {
            produtos.Add(produto);
            Console.WriteLine($"Produto '{produto.Nome}' adicionado com sucesso!");
        }
        else
        {
            Console.WriteLine("ID do produto já existe! Não é possível adicionar produtos com IDs duplicados.");
        }
    }

    public void AtualizarEstoque(int id, int quantidade)
    {
        var produto = BuscarProdutoPorId(id);
        if (produto != null)
        {
            produto.Quantidade += quantidade;
            Console.WriteLine($"Estoque atualizado. Nova quantidade de '{produto.Nome}': {produto.Quantidade}");
        }
        else
        {
            Console.WriteLine("Produto não encontrado!");
        }
    }

    public void AtualizarPreco(int id, double novoPreco)
    {
        var produto = BuscarProdutoPorId(id);
        if (produto != null)
        {
            produto.Preco = novoPreco;
            Console.WriteLine($"Preço do produto '{produto.Nome}' atualizado para R${novoPreco:F2}");
        }
        else
        {
            Console.WriteLine("Produto não encontrado!");
        }
    }

    public void ExibirProdutos()
    {
        Console.WriteLine("\nProdutos disponíveis no estoque:");
        foreach (var produto in produtos)
        {
            Console.WriteLine(produto);
        }
    }

    public void RegistrarVenda(int id, int quantidadeVendida)
    {
        var produto = BuscarProdutoPorId(id);
        if (produto != null && produto.Quantidade >= quantidadeVendida)
        {
            produto.Quantidade -= quantidadeVendida;
            Console.WriteLine($"Venda registrada: {quantidadeVendida} unidade(s) de '{produto.Nome}'. Estoque restante: {produto.Quantidade}");
        }
        else
        {
            Console.WriteLine("Estoque insuficiente ou produto não encontrado!");
        }
    }

    public void RemoverProduto(int id)
    {
        var produto = BuscarProdutoPorId(id);
        if (produto != null)
        {
            produtos.Remove(produto);
            Console.WriteLine($"Produto '{produto.Nome}' removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado!");
        }
    }

    public void PesquisarProduto(string termo)
    {
        var resultados = produtos.Where(p => p.Nome.Contains(termo, StringComparison.OrdinalIgnoreCase)).ToList();
        if (resultados.Any())
        {
            Console.WriteLine("\nResultados da pesquisa:");
            foreach (var produto in resultados)
            {
                Console.WriteLine(produto);
            }
        }
        else
        {
            Console.WriteLine("Nenhum produto encontrado!");
        }
    }

    public void ExibirProdutosEmBaixa(int limite)
    {
        var produtosEmBaixa = produtos.Where(p => p.Quantidade < limite).ToList();
        if (produtosEmBaixa.Any())
        {
            Console.WriteLine("\nProdutos com estoque abaixo do limite:");
            foreach (var produto in produtosEmBaixa)
            {
                Console.WriteLine(produto);
            }
        }
        else
        {
            Console.WriteLine("Nenhum produto em baixa!");
        }
    }

    public void GerarRelatorio(string nomeArquivo = "relatorio_estoque.txt")
    {
        using (StreamWriter sw = new StreamWriter(nomeArquivo))
        {
            foreach (var produto in produtos)
            {
                sw.WriteLine(produto);
            }
        }
        Console.WriteLine($"Relatório gerado: {nomeArquivo}");
    }

    public void SalvarEstoque()
    {
        using (StreamWriter sw = new StreamWriter(arquivoEstoque))
        {
            foreach (var produto in produtos)
            {
                sw.WriteLine($"{produto.Id},{produto.Nome},{produto.Preco},{produto.Quantidade}");
            }
        }
        Console.WriteLine("Estoque salvo em arquivo.");
    }

    public void CarregarEstoque()
    {
        if (File.Exists(arquivoEstoque))
        {
            try
            {
                using (StreamReader sr = new StreamReader(arquivoEstoque))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        var dados = linha.Split(',');
                        if (dados.Length == 4 &&
                            int.TryParse(dados[0], out int id) &&
                            double.TryParse(dados[2], out double preco) &&
                            int.TryParse(dados[3], out int quantidade))
                        {
                            string nome = dados[1];
                            var produto = new Produto(id, nome, preco, quantidade);
                            AdicionarProduto(produto);
                        }
                        else
                        {
                            Console.WriteLine($"Formato inválido na linha: {linha}");
                        }
                    }
                }
                Console.WriteLine("Estoque carregado do arquivo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar estoque: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Nenhum arquivo de estoque encontrado.");
        }
    }

    private Produto BuscarProdutoPorId(int id)
    {
        return produtos.Find(p => p.Id == id);
    }
}
