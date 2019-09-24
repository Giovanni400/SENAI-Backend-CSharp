using System;

namespace aula_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string[] nome = new string[10];
                float[] valor = new float[10];

                int op = 6;
                bool voltar = true;
                int p = 0;
                
                while(op != 0){
                    if(p < 10){
                        voltar = true;
                    }
                    Console.WriteLine(
                        @"
                        menu:
                        1- cadastrar um produto que tera o nome e preço  
                        2- listar todos os produtos 
                        3- calcular a soma de todos os preços dos produtos
                        0- sair"

                    );
                    Console.Write("digite uma opçao: ");
                    op = int.Parse(Console.ReadLine());
                    switch(op){

                        case 1:
                            //  cadastrar um produto que tera o nome e preço
                            if(p == 10){
                                Console.WriteLine("nao é possivel cadastrar mais produtos");
                            }else{
                                while(voltar == true){
                                    Console.WriteLine("digite o nome do produto: ");
                                    nome[p] = Console.ReadLine();
                                    Console.WriteLine("digite o valor do produto: ");
                                    valor[p] = float.Parse(Console.ReadLine());
                                
                                    if(p <= 9 ){
                                        Console.WriteLine("gostaria de cadastrar mais um produto? [true/false]");
                                        voltar = bool.Parse(Console.ReadLine());
                                        p++;
                                    }
                                    if(p == 10){
                                        voltar = false;
                                        Console.WriteLine("nao é possivel cadastrar mais produtos");
                                    }
                                }
                            
                            }
                            
                            
                        break;

                        case 2:
                            // listar todos os produtos
                            for(int c = 0; c <= (p-1); c++){
                                Console.WriteLine((c + 1) + "° produto: " + nome[c] );
                                Console.WriteLine((c + 1) + "° preço: " + valor[c] );
                            }
                        break;

                        case 3:
                            // calcular a soma de todos os preços dos produtos
                            float total = 0;
                            for(int c = 0; c <= p; c++){
                                total = total + valor[c];
                            }
                            Console.WriteLine("a soma total de todos os produtos é: " + total);
                        break;

                        default:
                            // nenhuma das opçoes selecionadas
                            Console.WriteLine("Opção invalida");
                        break;
                    }
                }



        }
    }
}
