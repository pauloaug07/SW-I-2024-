using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaQuadradoRetangulo
{
    public class Area
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int AreaCalc { get; set; }
        
        public int Calc()
        {
            AreaCalc = Base * Altura;
            return AreaCalc;
        }

        public string Calc2()
        {
            string resultado = "";
            AreaCalc = Base * Altura;

            if (Base == Altura)
            {
                resultado = "quadrado: " + AreaCalc;
            }
            else
            {
                resultado = "retângulo: " + AreaCalc;
            }
            
            return resultado;
        }

        public void ExibeValor()
        {
            Console.WriteLine("Base: " + Base);
            Console.WriteLine("Altura: " + Altura);
            Console.WriteLine("Área: " + AreaCalc);
        }
    }
}
