# Cadastro de Produtos
Este repositório contém uma implementação de um sistema de cadastro de produtos em C#.

## Funcionalidades
- Cadastro de novos produtos
- Listagem de produtos cadastrados
- Atualização do estoque de produtos
- Consulta do estoque de produtos
- Suporte a multiplos estoques

## Uso
Para usar o sistema, basta instanciar a classe CadastroProdutos e chamar os métodos CadastrarProduto, ListarProdutos, AtualizarEstoque e ConsultarEstoque.

Exemplo:
```csharp
CadastroProdutos cadastro = new CadastroProdutos();

Produto produto = new Produto {
    Id = 1,
    Nome = "Produto 1",
    Preco = 10.99m
};

cadastro.CadastrarProduto(produto);
cadastro.ListarProdutos();
```

## Testes
Este projeto contém testes unitários para verificar o funcionamento correto do sistema. Os testes foram escritos usando o XUnit.

Para executar os testes, abra o prompt de comando no diretório do projeto e execute o comando:

```shell
dotnet test
```
## Licença
Este projeto está licenciado sob a licença MIT. 