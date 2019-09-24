using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            float media;

            Console.WriteLine("informa um numero");
            num1 = int.Parse(Console.ReadLine());

            media = (num1) *3;
            Console.WriteLine("Sua média  é " + media);

            

            
        }
    }
}
