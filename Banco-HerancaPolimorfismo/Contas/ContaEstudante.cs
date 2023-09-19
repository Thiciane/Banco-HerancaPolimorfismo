public class Estudante : Banco
{
    public double LimiteChequeEspecial { get; set; }
    public string Cpf { get; set; }
    public string InstituicaoEnsino { get; set; }

    public Estudante(double limiteChequeEspecial, string cpf, string instituicaoEnsino, 
        int numeroConta, string agenciaConta, string titularConta, double saldoConta) :base(numeroConta, agenciaConta, titularConta, saldoConta)
    {
        this.LimiteChequeEspecial = limiteChequeEspecial;
        this.Cpf = cpf;
        this.InstituicaoEnsino = instituicaoEnsino;
    }

    public override double Saque(double valor)
    {
        if (valor > LimiteChequeEspecial)
        {
            Console.WriteLine("O valor de empréstimo não pode ser concedido!");
        }
        else { SaldoConta -= valor;
        }
        return SaldoConta;
    }
}