﻿using System;

namespace aula_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // deixamos declarada como falsa por padrão
            bool entrada = false;
            int idade;
            string retorno = "Entrada não permitida";

            Console.Write("Digite sua idade: ");
            idade  = int.Parse( Console.ReadLine() );

            // Como já atribuímos anteriormente, mudamos o
            // estado da variável para verdadeira caso
            // entre nessa condição
            if(idade > 17 ){
                entrada = true;
            }

            if( entrada == true ){
                retorno = "Entrada Permitida!!";
            }else{
                retorno = "Entrada não permitida :( ";
            }


            Console.WriteLine(retorno);




        }
    }
}