using CalculadoraDescontos.App;

var service = new DescontoService();
Console.WriteLine($"Categoria: {service.ObterCategoriaCliente(7)}");
Console.WriteLine($"Valor com desconto: {service.CalcularDescontoPorPercentual(100, 10)}");
Console.WriteLine($"Elegível para cupom: {service.EValidoParaCupom(20, false)}");
