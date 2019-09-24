using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            
        int numeros;
        int cont = 0;
        int valor = 0;

        do{
            Console.Write("Digite os 20 numeros: ");
            numeros = int.Parse(Console.ReadLine());
            cont++;
            if(numeros % 3 == 0){
                valor = valor + numeros;

            }

        }while(cont <= 20);
            Console.Write("A soma dos valores multiplos de 3 é " + valor);
            
    }
}
}
