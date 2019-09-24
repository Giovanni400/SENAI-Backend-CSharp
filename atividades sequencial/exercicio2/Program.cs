using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

        int valor;
        int percentual;
        float resultado;  

            Console.WriteLine();

            Console.WriteLine("Informe o preço de custo");
            valor = int.Parse(Console.ReadLine());

           

            Console.Write("Informe o percentual de acréscimo");

            Console.WriteLine();  

            percentual = int.Parse(Console.ReadLine());
              
            resultado = (valor) *10;
            
            resultado = (resultado) /100;
            
            resultado = (valor+resultado);
            
            Console.WriteLine("Valor de venda é " + resultado);
            
            
        }
    }
}
