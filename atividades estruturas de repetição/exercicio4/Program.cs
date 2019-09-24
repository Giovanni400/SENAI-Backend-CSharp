using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int vlr = 0;
            string vlrs_negativos = "";
            float media = 0;
            int m = 0;

                for(int n = 1; n <= 20; n++){

                
                    
                    Console.Write("Digite o " + n + "° valor: ");
                    vlr = int.Parse(Console.ReadLine());
                     
                    if(vlr < 0){
                        vlrs_negativos = vlrs_negativos + vlr + " ";
                        media = media - vlr;
                        m++;
                    }

        
                }
                        Console.WriteLine("Os valores negativos são: " + vlrs_negativos);
                        Console.WriteLine("A média dos valores negativos são: " + (media/m));

        }
    }
}
