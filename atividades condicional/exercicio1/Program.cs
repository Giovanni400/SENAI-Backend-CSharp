using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float salario,despesa,saldo;
    

            Console.Write("Digite o salário: ");
            salario =  float.Parse( Console.ReadLine() );


             Console.Write("Digite a sua despesa total: ");
            despesa =  float.Parse( Console.ReadLine() );

             saldo = (salario-despesa);

             if(saldo >= 0){
             Console.WriteLine("Positivo: ");

             }else{
             Console.WriteLine("negativo ");
             }



             
            
        }
    }
}
