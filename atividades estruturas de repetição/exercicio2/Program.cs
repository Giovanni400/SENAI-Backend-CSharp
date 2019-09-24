using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numero;

            Console.WriteLine("Digite o numero");
            numero = int.Parse(Console.ReadLine());

            for(int cont = 1; cont <= 10; cont ++){
                int calculo = numero * cont;

                Console.WriteLine($"{numero} x {cont} = {calculo}" );

                
            }

                



        }
    }
}
