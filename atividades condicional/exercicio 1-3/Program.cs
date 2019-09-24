using System;

namespace exercicio_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float gravidade, resultado = 0;
            int peso;
            string planeta = "1";

        Console.Write("Digite seu peso: ");
        peso = int.Parse(Console.ReadLine());

        Console.Write("Digite o numero de um planeta: ");
        planeta = Console.ReadLine();
         
        switch(planeta){
                
                case "1":
                planeta = "Mercurio";
                gravidade = 0.37f;
                break;

                case "2":
                planeta = "Venus";
                gravidade = 0.88f;
                break;

                case "3":
                planeta = "Marte";
                gravidade = 0.38f;
                break;

                case "4":
                planeta = "Jupiter";
                gravidade = 2.64f;
                break;

                case "5":
                planeta = "Saturno";
                gravidade = 1.15f;
                break;

                case "6":
                planeta = "Urano";
                gravidade = 1.17f;
                break;

                default:
                gravidade = 0;
                planeta = "erro";
                break;
     
        }
        resultado = peso/10 *gravidade;
        
        Console.WriteLine("seu peso no planeta " +planeta+ " é " + resultado );
    }
    }
}

