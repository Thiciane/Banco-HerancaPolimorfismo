public class Banco
{
    public int NumeroConta { get; set; }
    public string AgenciaConta { get; set; }
    public string TitularConta { get; set; }
    public double SaldoConta { get; set; }

    public Banco(int numeroConta, string agenciaConta, string titularConta, double saldoConta)
    {
        this.NumeroConta = numeroConta;
        this.AgenciaConta = agenciaConta;
        this.TitularConta = titularConta;
        this.SaldoConta = saldoConta;
    }
 

    public virtual double Saque(double valor)
    {
        if (valor < SaldoConta) 
        { SaldoConta -= valor; }
        return SaldoConta;
    }
    public virtual double Deposito(double valor)
    {
        SaldoConta += valor;
        return SaldoConta;

    }
}

