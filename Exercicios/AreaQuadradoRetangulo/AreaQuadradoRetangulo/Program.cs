namespace AreaQuadradoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de area de quadrado/retangulo");
           
            Area area1= new Area();

            Console.WriteLine("Digite o valor da base:");
            area1.Base = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura:");
            area1.Altura = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Valor da área: " + area1.Calc());
            Console.WriteLine("A área do " + area1.Calc2());

            area1.ExibeValor();
        }
    }
}