namespace ExemploParametro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area area1= new Area();
            
            Console.WriteLine("Digite o valor de base:");
            area1.Base = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de altura:");
            area1.Altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite:\n1 para quadrado\n2 para retângulo\n3 para triângulo.");
            Console.WriteLine("--------------------------");
            
            int opcao = Convert.ToInt32(Console.ReadLine());
            area1.Escolha(opcao);    
        }
    }
}