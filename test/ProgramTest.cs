using Xunit;

namespace CadastroProduto;

public class CadastroProdutosTests {
    [Fact]
    public void Deve_Cadastrar_Produto() {
        // Arrange
        Produto produto = new Produto {
            Id = 1,
            Nome = "Produto 1",
            Preco = 10.99m
        };

        // Act
        CadastroProdutos.CadastrarProduto(produto);
        var produtos = CadastroProdutos.ListarProdutos();

        // Assert
        Assert.Contains(produto, produtos);
    }

    [Fact]
    public void Deve_Atualizar_Estoque() {
        // Arrange
        Produto produto = new Produto {
            Id = 1,
            Nome = "Produto 1",
            Preco = 10.99m
        };
        CadastroProdutos.CadastrarProduto(produto);
        var quantidadeInicial = CadastroProdutos.ConsultarEstoque(1, "Estoque 1");

        // Act
        CadastroProdutos.AtualizarEstoque(1, "Estoque 1", 20);
        var quantidadeFinal = CadastroProdutos.ConsultarEstoque(1, "Estoque 1");

        // Assert
        Assert.NotEqual(quantidadeInicial, quantidadeFinal);
        Assert.Equal(20, quantidadeFinal);
    }

    [Fact]
    public void Deve_Consultar_Estoque() {
        // Arrange
        Produto produto = new Produto {
            Id = 1,
            Nome = "Produto 1",
            Preco = 10.99m,
            Estoques = new Dictionary<string, int> {
                { "Estoque 1", 10 }
            }
        };
        CadastroProdutos.CadastrarProduto(produto);

        // Act
        var quantidade = CadastroProdutos.ConsultarEstoque(1, "Estoque 1");

        // Assert
        Assert.Equal(10, quantidade);
    }
}
