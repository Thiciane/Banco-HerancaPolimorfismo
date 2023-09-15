
public class Empresa : Banco
{
    public double TaxaAnuidade { get; set; }
    public double LimiteEmprestimo { get; set; }
    public double TotalEmprestimo { get; set; }

    public Empresa(int taxaAnuidade, double limiteEmprestimo, double totalEmprestimo,
        int numeroConta, string agenciaConta, string titularConta, double saldoConta) : base( numeroConta,  agenciaConta,  titularConta, saldoConta)
    {
        this.TaxaAnuidade = taxaAnuidade;
        this.LimiteEmprestimo = limiteEmprestimo;
        this.TotalEmprestimo = totalEmprestimo;
    }

    public void Emprestimo(double valor)
    {
        if (valor > LimiteEmprestimo) { 
            Console.WriteLine("O valor de empréstimo não pode ser concedido!"); 
        }
        else { 
            SaldoConta += valor; 
            TotalEmprestimo += valor; 
            Console.WriteLine("O empréstimo foi realizado com sucesso!"); 
        }
        Console.WriteLine(SaldoConta);
    }
    public void Saque(double valor)
    {
        if (valor > SaldoConta)
        {
            Console.WriteLine("O valor de saque não pode ser concedido!");
        }
        else if(valor > 5000) {SaldoConta -= valor+5;
            Console.WriteLine(SaldoConta);
        }

    }
}