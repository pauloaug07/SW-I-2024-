using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AreaQuadradoRetangulo 
{ 
    public class Area 
    { 
        public float Base { get; set; } 
        public float Altura { get; set; } 
        public float AreaCalc { get; set; } 
     
        public void Calculo() { 
            Console.WriteLine("Digite o valor da base da forma a ser calculada:"); 
            Base = float.Parse(Console.ReadLine()); 
            Console.WriteLine("Digite o valor da altura da forma a ser calculada:"); 
            Altura = float.Parse(Console.ReadLine()); AreaCalc = Base * Altura; 
            
            if (Base == Altura) 
            { 
                Console.WriteLine("A área do QUADRADO é: " + AreaCalc); 
            } 
            else if (Base != Altura) 
            { 
                Console.WriteLine("A área do RETÂNGULO é: " + AreaCalc); 
            } 
        } 
        
        public string MostrarDados() { 
            return ("Base: " + Base + "\nAltura: " + Altura + "\nÁrea: " + AreaCalc); 
        } 
    } 
}
