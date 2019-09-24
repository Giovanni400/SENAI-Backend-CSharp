using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float precototal,valor;
        

            Console.Write("Digite o preço total: ");
            precototal =  float.Parse( Console.ReadLine() );

          
            valor = precototal - 25;
            
            if(precototal <= 100){
                Console.WriteLine("valor final: " + valor);
             }else{
                Console.Write("valor final: " + precototal); 

             }

        }
    }
}
