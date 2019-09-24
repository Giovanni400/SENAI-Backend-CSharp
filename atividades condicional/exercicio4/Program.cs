using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
             float precototal, valor;

            Console.Write("Digite o preco total a ser pago");
            precototal  =  float.Parse( Console.ReadLine() );

            Console.Write("Digite o preco total a ser pago");
            valor  =  float.Parse( Console.ReadLine() );

            if(precototal <= 1000){
                Console.WriteLine("precototal: " + valor);
             }else{
            if(valor <= 100)
                Console.Write("valor: " + precototal);

             

             }
        }
    }
}
