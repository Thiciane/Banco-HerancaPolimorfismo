while (true)
{
    Console.WriteLine("saldo:");
    double saldo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Banco Normal");
    Banco banco = new Banco(0001, "agencia", "sicoob", saldo);
    banco.Deposito(200);
    banco.Saque(500);

    Console.WriteLine("Banco Empresa");
    Empresa empresa = new Empresa(10, 5000, 2000, 0001, "agencia", "sicoob", saldo);
    empresa.Deposito(200);
    empresa.Saque(500);
    
    Console.WriteLine("Banco Estudante");
    Estudante estudante = new Estudante(10, "000", "Ifro", 0001, "agencia", "sicoob", saldo);
    estudante.Saque(500);
}


Console.ReadKey();