using System;

namespace exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[]valor1 = new string[10];
            string[]valor2 = new string[10];

            
            for(int i = 0; i <= 9 ; i++){

                Console.Write("Digite o Valor: ");
                valor1[i] = Console.ReadLine();
            }

                for(int i = 0; i <= 9; i++){
                    
                Console.Write("Digite o Valor: ");
                valor2[i] = Console.ReadLine();

                }

                for(int i = 9; i <= 0; i++){
                    Console.WriteLine(valor2[i]);
                    
                }

                













        

        }
    }
}
