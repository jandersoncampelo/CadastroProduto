using System;
using System.Collections.Generic;

namespace CadastroProduto;
public class Produto {
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public Dictionary<string, int> Estoques { get; set; } = new Dictionary<string, int>();
}

public class CadastroProdutos {
    private static List<Produto> produtos = new List<Produto>();

    public static void CadastrarProduto(Produto produto) {
        produtos.Add(produto);
        Console.WriteLine("Produto cadastrado com sucesso!");
    }

    public static void ListarProdutos() {
        Console.WriteLine("Lista de produtos:");
        foreach (Produto p in produtos) {
            Console.WriteLine("- " + p.Nome + ", R$" + p.Preco);
            foreach (KeyValuePair<string, int> estoque in p.Estoques) {
                Console.WriteLine("  - Estoque: " + estoque.Key + ", Quantidade: " + estoque.Value);
            }
        }
    }

    public static void AtualizarEstoque(int idProduto, string nomeEstoque, int quantidade) {
        Produto produto = produtos.Find(p => p.Id == idProduto);
        if (produto == null) {
            Console.WriteLine("Produto não encontrado.");
            return;
        }
        if (produto.Estoques.ContainsKey(nomeEstoque)) {
            produto.Estoques[nomeEstoque] = quantidade;
        } else {
            produto.Estoques.Add(nomeEstoque, quantidade);
        }
        Console.WriteLine("Estoque atualizado com sucesso!");
    }

    public static void ConsultarEstoque(int idProduto, string nomeEstoque) {
        Produto produto = produtos.Find(p => p.Id == idProduto);
        if (produto == null) {
            Console.WriteLine("Produto não encontrado.");
            return;
        }
        if (produto.Estoques.ContainsKey(nomeEstoque)) {
            Console.WriteLine("Estoque: " + nomeEstoque + ", Quantidade: " + produto.Estoques[nomeEstoque]);
        } else {
            Console.WriteLine("Estoque não encontrado.");
        }
    }
}
