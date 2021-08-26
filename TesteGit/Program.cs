using System;

namespace TesteGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero: ");
            double n1= double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            double n2= double.Parse(Console.ReadLine());
            Console.Write("Digite o simbolo da operação:");
            string op = Console.ReadLine();

            double r;
            switch (op)
            {
                
                case "+":
                    r = n1 + n2;
                       Console.WriteLine(r);
                    break;
                case "/":
                    r = n1 / n2;
                    Console.WriteLine(r);
                    break;
                case "-":
                    r = n1 - n2;
                    Console.WriteLine(r);
                    break;
                case "*":
                    r = n1 * n2;
                    Console.WriteLine(r);
                    break;



            }
        }
    }
}
