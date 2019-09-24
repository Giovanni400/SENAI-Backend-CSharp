using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1,num2;

            Console.Write("Insira o primeiro numero");
            num1  =  float.Parse( Console.ReadLine() );

            Console.Write("Insira o segundo numero");
            num2  =  float.Parse( Console.ReadLine() );

            if(num1 > num2){
               Console.WriteLine("o maior valor é: "+ num1); 
            }else{
               Console.WriteLine("o maior valor é: "+ num2); 
            }
            

        }
    }
}
