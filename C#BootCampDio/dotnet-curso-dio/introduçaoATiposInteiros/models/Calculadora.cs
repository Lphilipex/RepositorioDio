using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introduçaoATiposInteiros.models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
            /*símbolo "$" no início da string permite a interpolação de variáveis dentro da string, ou seja, a 
            inclusão de valores de variáveis dentro do texto. Isso é feito colocando o nome da variável dentro de chaves "{}" dentro da string.
            */        
        }


        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y )
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"seno de {angulo}° {Math.Round(seno, 4)}");

        }

         public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double  coseno = Math.Cos(radiano);
            Console.WriteLine($"coseno de {angulo}° {Math.Round(coseno, 4)}");

        }


         public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"tangente de {angulo}° {Math.Round(tangente, 4)}");

        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"rais de {x} = {Math.Round(raiz, 4 )}");
        }
    
    
    
    }


}


