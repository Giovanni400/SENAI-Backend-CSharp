using System;

namespace exercicio_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            

       string pedido;
       string resultado = "";

       Console.Write("Digite o numero do pedido: ");
       pedido = Console.ReadLine();

       
       Console.WriteLine(pedido);

       switch(pedido){
                
                case "1":
                resultado = "Switch - Hamburguer";
                break;

                case "2":
                resultado = "Switch - Cheesesalada";
                break;

                case "3":
                resultado = "Switch - cheeseburguer";
                break;

                case "4":
                resultado = "Switch - cheesebacon";
                break;

                default:
                resultado = "Switch - Entrada Inválida! :(";
                break;
    
        }
        Console.WriteLine(resultado);
    }
}
}
