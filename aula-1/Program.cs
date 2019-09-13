using System;

namespace aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            // Somente declaramos, sem atribuir valor
            int num1;

            // Declaramos atribuindo um Valor
            int num2 = 5;

            // Declaramos diversas variáveis do mesmo tipo
            int num3, num4, num5;

            // variavel do tipo decimal (real)
            float media;

            // variável do tipo lógico (booleana)
            bool resultado = false;

            // Variável do tipo texeto (caracteres)
            string nomeAluno;

            // Quebra de linha
            Console.WriteLine();

            // Escreve em uma linha querando-a
            Console.WriteLine("Bem vindos á nossa aplicação");

            // Continua escrevendo na mesma linha
            Console.Write("Digite");
            Console.Write(" seu nome: ");
         
            // Capturo p dado digitado pelo usuário e salvo na variável
            nomeAluno = Console.ReadLine();

            // Concatenação
            Console.WriteLine(nomeAluno + ", Agora digite sua primeira nota");

            num3 = int.Parse(Console.ReadLine());

            // Interpolação
            Console.WriteLine($"Sua primeira nota é {num3} ");

            Console.WriteLine("Digite sua segunda nota: ");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota: ");
            num5 = int.Parse(Console.ReadLine());


            media = (num3+num4+num5) /3;
            Console.WriteLine("Sua média é" + media);
        }
    }
}
