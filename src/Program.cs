// See https://aka.ms/new-console-template for more information
using CadastroProduto;

Produto produto = new Produto
{
    Id = 1,
    Nome = "Produto 1",
    Preco = 10.99m
};
CadastroProdutos.CadastrarProduto(produto);
CadastroProdutos.ListarProdutos();