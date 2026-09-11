using AppPOOAlugaFacil.Model;

Cliente cliente = new Cliente();
    Console.WriteLine("informe o CPF do cliente:");
    cliente.cpf = Console.ReadLine();

    Console.WriteLine("informe o nome do cliente:");
    cliente.nome = Console.ReadLine();

    Console.WriteLine("informe a cnh do cliente:");
    cliente.cnh = Console.ReadLine();



Console.WriteLine("");
Console.WriteLine("Dados do cliente");

Console.WriteLine($"CPF: {cliente.cpf}\r\n" +
                  $"CNH: {cliente.cnh}\r\n" +
                  $"Nome: {cliente.nome} ");   







Carro carro = new Carro();

    Console.WriteLine("informe o Id do carro");
    carro.idcarro = Console.ReadLine();

    Console.WriteLine("informe a placa do carro:");
    carro.placa = Console.ReadLine();
    
    Console.WriteLine("informe o fabricante do carro:");
    carro.placa = Console.ReadLine();
    
    Console.WriteLine("informe o modelo do carro:");
    carro.modelo = Console.ReadLine();

    Console.WriteLine("informe o ano do carro:");
    carro.ano = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("informe a cor do carro:");
    carro.cor = Console.ReadLine();
    
    Console.WriteLine("informe o valor da diaria do carro:");
    carro.ValorDiaria = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Id: {carro.idcarro}\r\n" +
              $"Placa: {carro.placa}\r\n" +
              $"Modelo: {carro.modelo}\r\n" +
              $"Valor da diária: {carro.ValorDiaria}\r\n" +
              $"Ano do carro: {carro.ano}\r\n" +
              $"Fabricante: {carro.fabricante} "
              );




Locacao locacao = new Locacao();
