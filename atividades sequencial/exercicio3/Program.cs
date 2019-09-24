using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int salario;
            int vendas;
           
            double total;

            Console.WriteLine();

            Console.WriteLine("Informe o salario fixo");
            salario = int.Parse(Console.ReadLine());


            Console.WriteLine("Informe o total das vendas");
            vendas = int.Parse(Console.ReadLine());


            total = salario + vendas*3;   
            Console.WriteLine(total);
    
    
    
    }
}
}
