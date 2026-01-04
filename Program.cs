// See https://aka.ms/new-console-template for more information
using System;
  class Program
{  
    static void Main(string[] args)
    {
     //Entrada dos Valores
     Console.Write("Digite o valor de A");
     double a = double.Parse(Console.ReadLine()!);

     Console.Write("Digite o valor de B");
     double b = double.Parse(Console.ReadLine()!);

     Console.Write("Digite o valor de C");
     double c = double.Parse(Console.ReadLine()!);

     //Calculo do Delta
     double delta = (b * b) - (4*a*c);
     Console.WriteLine($"\nDelta = {delta}");

     //Verifiçação do tipo das Raízes
     if (delta > 0)
        {
            //duas raizes reais e distintas
            double x1 = (-b + Math.Sqrt(delta))/(2*a);
            double x2 = (-b - Math.Sqrt(delta))/(2*a);
            Console.WriteLine("A equação possui duas raizes reais:");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
                    }
        else if (delta == 0)
        {
            //uma raiz real dupla
            double x = -b / (2*a);
            Console.WriteLine("A equação possui uma raiz real dupla:");
            Console.WriteLine($"x = {x}");
        }
        else
        {
            //raizes complexas
            double parteReal = -b / (2*a);
            double parteImaginaria = Math.Sqrt(-delta) / (2*a);

            Console.WriteLine("A equação possui raízes complexas:");
            Console.WriteLine($"x1 = {parteReal} + {parteImaginaria}i");
            Console.WriteLine($"x2 = {parteReal} - {parteImaginaria}i");
        }
    }
}
