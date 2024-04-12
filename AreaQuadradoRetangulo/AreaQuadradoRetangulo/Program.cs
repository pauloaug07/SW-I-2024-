namespace AreaQuadradoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de area de quadrado/retangulo");

            Area figura1 = new Area();
            figura1.Calculo();
            Console.WriteLine(figura1.MostrarDados());

            Console.ReadKey();
        }
    }
}
