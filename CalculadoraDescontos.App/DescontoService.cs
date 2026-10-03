namespace CalculadoraDescontos.App;

public class DescontoService
{
    public string ObterCategoriaCliente(int totalCompras)
    {
        if (totalCompras < 5)
        {
            return "BRONZE";
        }

        return totalCompras <= 10 ? "PRATA" : "OURO";
    }

    public int CalcularDescontoPorPercentual(int valorOriginal, int percentualDesconto)
    {
        return (int)((long)valorOriginal * (100 - (long)percentualDesconto) / 100);
    }

    public bool EValidoParaCupom(int idade, bool primeiraCompra)
    {
        return idade >= 18 || primeiraCompra;
    }
}
