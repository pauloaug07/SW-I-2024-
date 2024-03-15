namespace ContaDeBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            Console.WriteLine("Bem vindo ao Banco da ETEC MCM!");
            Console.WriteLine("CONSULTANDO O SALDO...");
            conta.consulta_saldo();
            
            Console.WriteLine("EFETUANDO UM DEPÓSITO DE R$ 1000,35");
            conta.depositar(1000.35);
            Console.WriteLine("CONSULTANDO O SALDO...");
            conta.consulta_saldo();

            //Console.WriteLine("EFETUANDO UM SAQUE DE R$ 15,99");
            //conta.sacar(500);
            //Console.WriteLine("CONSULTANDO O SALDO...");
            //conta.consulta_saldo();

            //Console.WriteLine("EFETUANDO UM SAQUE DE R$ 45,99");
            //conta.sacar(1200);

            conta.ajusta_limite(1000);
            conta.consulta_saldo();
            conta.sacar(2000);
            conta.consulta_saldo();
        }
    }
}