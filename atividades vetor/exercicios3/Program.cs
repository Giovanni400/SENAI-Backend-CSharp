using System;

namespace exercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[]nomeproduto = new string[12];
            string[]cor = new string[12];
            string[]tamanho = new string[12];
            string[]preco = new string[12];

            for(int i = 0; i <= 11 ; i++){

                Console.Write("Digite o nome do produto : ");
                nomeproduto[i] = Console.ReadLine();
            }

            for(int i = 0; i <= 11 ; i++){

                Console.Write("Digite a cor: ");
                cor[i] = Console.ReadLine();
            }

            for(int i = 0; i <= 11 ; i++){

                Console.Write("Digite o tamanho: ");
                tamanho[i] = Console.ReadLine();
            }

            for(int i = 0; i <= 11 ; i++){

                Console.Write("Digite o preco: ");
                preco[i] = Console.ReadLine();
            }

            
            
        

            
        }
    }
}
