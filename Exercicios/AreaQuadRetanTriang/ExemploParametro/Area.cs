using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploParametro
{
    public class Area
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public float AreaCalc { get; set; }

        public void Escolha(int opcao)
        {
            if (opcao == 1)
            {
                float quadrado = CalcQuad();
                Console.WriteLine("Área do quadrado é: " + quadrado);
            } 
            if (opcao == 2)
            {
                float retangulo = CalcRetan();
                Console.WriteLine("Área do retângulo é: " + retangulo);
            }
            if (opcao == 3) 
            {
                float triangulo = CalcTriang();
                Console.WriteLine("Área do triângulo é: " + triangulo);
            }
        }

        public float CalcQuad()
        {
            AreaCalc = Base * Base;
            return AreaCalc;
        }

        public float CalcRetan()
        {
            AreaCalc = Base * Altura;
            return AreaCalc;
        }
        
        public float CalcTriang()
        {
            AreaCalc = (Base * Altura) / 2;
            return AreaCalc;
        }
    }
}
