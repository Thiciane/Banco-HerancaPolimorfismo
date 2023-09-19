sair:;
Console.WriteLine("\nsaldo:");
double saldo = Convert.ToDouble(Console.ReadLine());

double valor;


Console.WriteLine("1- Empresa\n2- Estudante\n3- Normal");
int opc = Convert.ToInt32(Console.ReadLine());

while (true)
{

    switch (opc)
    {
        case 1:
            Console.WriteLine("\nBanco Empresa");
            Empresa empresa = new Empresa(10, 5000, 2000, "agencia", "sicoob", saldo);

            while (true)
            {
                Console.WriteLine("1- Emprestimo\n2- Saque\n3- Deposito\n4- sair");
                int opcEmpresa = Convert.ToInt32(Console.ReadLine());

                switch (opcEmpresa)
                {
                    case 1:
                        Console.WriteLine("\nvalor:");
                        Console.WriteLine(empresa.Emprestimo(valor = Convert.ToDouble(Console.ReadLine())));
                        break;
                    case 2:
                        Console.WriteLine("\nvalor:");
                        Console.WriteLine(empresa.Saque(valor = Convert.ToDouble(Console.ReadLine())));
                        break;
                    case 3:
                        Console.WriteLine("\nvalor:");
                        Console.WriteLine(empresa.Deposito(valor = Convert.ToDouble(Console.ReadLine())));
                        break;
                    default:
                        goto sair;
                        break;
                }
            }
            break;
        case 2:
            Console.WriteLine("\nBanco Estudante");
            Estudante estudante = new Estudante(1000, "000", "Ifro", 0001, "agencia", "sicoob", saldo);
            while (true)
            {
                Console.WriteLine("1- Saque\n2- Deposito\n3- sair");
                int opcEstudante = Convert.ToInt32(Console.ReadLine());

                switch (opcEstudante)
                {
                    case 1:
                        Console.WriteLine("\nvalor:");
                        Console.WriteLine(estudante.Saque(valor = Convert.ToDouble(Console.ReadLine())));
                        break;
                    case 2:
                        Console.WriteLine("\nvalor:");
                        Console.WriteLine(estudante.Deposito(valor = Convert.ToDouble(Console.ReadLine())));
                        break;
                    default:
                        goto sair;
                        break;
                }
            }
            break;
        case 3:
            Console.WriteLine("\nBanco Normal");
            Banco banco = new Banco(0001, "agencia", "sicoob", saldo);
            while (true)
            {
                Console.WriteLine("1- Saque\n2- Deposito\n3- sair");
                int opcNormal = Convert.ToInt32(Console.ReadLine());

                switch (opcNormal)
                {
                    case 1:
                        Console.WriteLine("\nvalor:");
                        Console.WriteLine(banco.Saque(valor = Convert.ToDouble(Console.ReadLine())));
                        break;
                    case 2:
                        Console.WriteLine("\nvalor:");
                        Console.WriteLine(banco.Deposito(valor = Convert.ToDouble(Console.ReadLine())));
                        break;
                    default :
                        goto sair;
                        break;
                }
            }
            break;
    }    

}


Console.ReadKey();