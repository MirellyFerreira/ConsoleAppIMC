using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu peso?: ");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua altura?: ");
            double a = double.Parse(Console.ReadLine());

            double imc = p / (a * a);

            if (imc <= 17)
            {
                Console.WriteLine("Seu imc é" + imc);
                Console.WriteLine(" Você está muito abaixo do peso");
            }
            else if (imc >= 18.4)
            {
                Console.WriteLine("Seu imc é" + imc);
                Console.WriteLine(" Você está abaixo do peso");
            }
            else if (imc >= 24.9)
            {
                Console.WriteLine("Seu imc é" + imc);
                Console.WriteLine("Você está com o peso normal");
            }
            else if (imc >= 29.9)
            {
                Console.WriteLine("Seu imc é" + imc);
                Console.WriteLine("Você está acima do peso");
            }
            else if (imc <= 34.9)
            {
                Console.WriteLine("Seu imc é" + imc);
                Console.WriteLine(" Você está com obesidade grau I");
            }
            else if (imc <= 40)
            {
                Console.WriteLine("Seu imc é" + imc);
                Console.WriteLine(" Você está com obesidade grau II");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Seu imc é" + imc);
                Console.WriteLine(" Você está com obesidade grau III");
            }
                Console.ReadKey();
        }
               
    }
         
}


    
