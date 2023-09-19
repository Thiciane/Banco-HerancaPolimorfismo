
public class Empresa : Banco
{
    public double TaxaAnuidade { get; set; }
    public double LimiteEmprestimo { get; set; }
    public double TotalEmprestimo { get; set; }

    public Empresa(int taxaAnuidade, double limiteEmprestimo,
        int numeroConta, string agenciaConta, string titularConta, double saldoConta) : base( numeroConta,  agenciaConta,  titularConta, saldoConta)
    {
        this.TaxaAnuidade = taxaAnuidade;
        this.LimiteEmprestimo = limiteEmprestimo;
    }

    public double Emprestimo(double valor)
    {
        if (valor > LimiteEmprestimo - TotalEmprestimo) { 
            Console.WriteLine("O valor de empréstimo não pode ser concedido!"); 
        }
        else { 
            SaldoConta += valor; 
            TotalEmprestimo += valor; 
            Console.WriteLine("O empréstimo foi realizado com sucesso!"); 
        }
        return(SaldoConta);
    }
    public override double Saque(double valor)
    {
        if (valor > SaldoConta)
        {
            Console.WriteLine("O valor de saque não pode ser concedido!");
        }
        else {
            if (SaldoConta >= 5000)
            {
                SaldoConta -= valor + 5;

            }
        }
        return (SaldoConta);
    }
}