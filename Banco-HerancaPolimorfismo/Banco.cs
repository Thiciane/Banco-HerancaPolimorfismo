public class Banco
{
    public string numeroConta { get; set; }
    public string agenciaConta { get; set; }
    public string titularConta { get; set; }
    public double saldoConta { get; set; }

    public Banco(string numeroConta, string agenciaConta, string titularConta, double saldoConta)
    {
        this.numeroConta = numeroConta;
        this.agenciaConta = agenciaConta;
        this.titularConta = titularConta;
        this.saldoConta = saldoConta;
    }

    public (bool, double) Saque(double valor)
    {
        bool verifica = true;

        if (valor > saldoConta) {  verifica = false; }
        else { verifica = true; saldoConta -= valor; }

        return (verifica, saldoConta);
    }
    public double Deposito(double valor)
    {
        return saldoConta += valor;
    }
}

public class Estudante : Banco
{
    //terminar
}
public class Empresa : Banco
{
    public int taxaAnuidade { get; set; }
    public double limiteEmprestimo { get; set; }
    public double totalEmprestimo { get; set; }
    
    //construtor empresa

    public double Emprestimo()
    {

    }
}
/*
Esse tipo de conta também possui uma ação para realizar
empréstimo, a qual deve receber um valor de empréstimo e verificar se o cliente
possui limites para realizar tal empréstimo. Caso o cliente possui tal permissão, o
saldo da conta e o total de empréstimo devem incrementar o valor de empréstimo e
apresentar a mensagem dizendo que o empréstimo foi realizado com sucesso. Caso o
cliente não possui tal permissão (pois o limite de empréstimo se excede com o valor),
o sistema deve apresentar a mensagem dizendo que o valor de empréstimo não pode
ser concedido. Por fim, a conta para empresa possui uma taxa para saques acima de
R$ 5000,00 que é de R$ 5,00. 
*/