using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
         
        double real;
        double dollar;
        double total;

        Console.WriteLine();

        Console.WriteLine("Digite o valor do real");
        real = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do dollar");
        dollar =  float.Parse(Console.ReadLine());

        total =  real/dollar;
        Console.WriteLine(total);
    }
}

}