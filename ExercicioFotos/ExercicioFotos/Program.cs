using System;

namespace ExercicioFotos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de caso certo:");
            AlbumDeFotos albumCerto = new AlbumDeFotos();
            albumCerto.CriarAlbum(42, 20);
            
            Console.WriteLine("======================");
            Console.WriteLine("======================");
            Console.WriteLine("======================");
           
            Console.WriteLine("Exemplo de caso errado:");
            AlbumDeFotos albumErrado = new AlbumDeFotos();
            albumErrado.CriarAlbum(40, 84);
        }
    }
}
