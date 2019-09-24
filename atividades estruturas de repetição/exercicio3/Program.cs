using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numeros;
            int cont = 0;
            string valor = "";
            
            Console.Write("Digite o numero: ");
            numeros = int.Parse(Console.ReadLine());

            do{
                
                cont++;
                if(cont % 5 == 0){
                    valor = valor + " " + cont.ToString();
                }

            }while(cont <= numeros);
            
            Console.Write("A soma dos valores multiplos de 5 é " + valor);
        }

    }
}
