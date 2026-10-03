# CalculadoraDescontos

Lista 23 de Garantia da Qualidade de Software / Gestão e Qualidade de Software. Professor Daniel Henrique Matos de Paiva.

**Autor:** Cláudio Martins Camilo  
**RA:** 325131832

## Tecnologias e estrutura

- C# e .NET 10.
- xUnit para testes parametrizados.
- CalculadoraDescontos.sln: solução com os dois projetos.
- CalculadoraDescontos.App: aplicação de console e classe DescontoService.
- CalculadoraDescontos.Tests: testes com referência ao projeto App.

## Métodos

| Método | Comportamento |
| --- | --- |
| ObterCategoriaCliente(int totalCompras) | BRONZE abaixo de 5 compras; PRATA de 5 a 10, inclusive; OURO acima de 10. |
| CalcularDescontoPorPercentual(int valorOriginal, int percentualDesconto) | Retorna o valor final após aplicar o desconto percentual. Exemplo: 100 com 10% retorna 90. Como o retorno é inteiro, eventual fração do valor final é truncada. |
| EValidoParaCupom(int idade, bool primeiraCompra) | Retorna true quando a idade é pelo menos 18 anos ou é a primeira compra; false nos demais casos. |

## Diferença entre [Fact] e [Theory]

[Fact] representa um teste único, sem parâmetros, usado para verificar um cenário específico.

[Theory] representa um teste parametrizado: o mesmo método recebe diferentes entradas. Cada [InlineData] fornece um conjunto de argumentos e é executado como um caso individual. Isso permite testar vários cenários sem duplicar o método.

Nesta atividade há três métodos com [Theory] e três [InlineData] em cada um: **nove casos de teste individuais**. Todos usam Assert.Equal para comparar o resultado com o valor esperado, inclusive no retorno booleano.

## Cobertura dos testes

| Método | Dados de entrada e resultado esperado |
| --- | --- |
| Categoria | 2 → BRONZE; 7 → PRATA; 15 → OURO |
| Desconto | (100, 10) → 90; (200, 20) → 160; (50, 0) → 50 |
| Cupom | (20, false) → true; (16, true) → true; (17, false) → false |

## Como executar

Instale o SDK .NET 10 e execute na raiz do repositório:

```sh
dotnet build
dotnet test
```

O build restaura as dependências e compila os projetos. O comando dotnet test executa os nove casos do xUnit.

Para visualizar cada caso parametrizado no terminal:

```sh
dotnet test --logger "console;verbosity=normal"
```

Para executar a demonstração:

```sh
dotnet run --project CalculadoraDescontos.App
```

## Licença

Licença MIT, disponível no arquivo LICENSE.
