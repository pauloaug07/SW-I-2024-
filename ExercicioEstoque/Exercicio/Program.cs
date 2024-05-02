namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GERENCIAMENTO DE ESTOQUE");
            Console.WriteLine("========================");

            Produto produto1 = new Produto(22067, "Escova de dente", 0, 5.75);
            produto1.imprimir();
            Console.WriteLine("========================");

            produto1.entrada(20);
            produto1.imprimir();
            Console.WriteLine("========================");

            produto1.venda(5);
            produto1.imprimir();

            Console.ReadLine();
        }
    }
}
