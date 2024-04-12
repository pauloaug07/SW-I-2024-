namespace ExercicioSite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Paulo";
            pessoa1.DataNascimento = new DateTime(2008, 6, 2);
            pessoa1.Altura = 1.69f;

            pessoa1.ImprimirDados();

            int idade = pessoa1.CalcularIdade();

            Console.WriteLine("Idade: " + idade + " anos");

            Console.ReadKey();
        }
    }
}
