using System;

namespace exercicios7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[]vetor1 = new int[10];
            
            //int i = 0;

             for(int i = 0; i <= 9 ; i++){

                Console.Write("Insira um valor : ");
                vetor1[i] = int.Parse(Console.ReadLine());

                if(i == 0){
                    maior = vetor1;
                
                }
            }




        }
    }
}
