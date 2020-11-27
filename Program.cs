using System;

namespace SistemaDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarações de variaveis
            int escolha;
            int produtos = 0;
            string resposta; 
            string promocao;
            string[] nomes = new string [10];
            string[] produto = new string [10];   
            string[] preco = new string [10];
            bool[] promo = new bool [10];
            
            
            Console.WriteLine("--------------------------");
            Console.WriteLine("----Sistama De Produtos---");
            Console.WriteLine("--------------------------");

            //menu
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("Selecione uma opção abaixo");
                Console.WriteLine("[1] Nome do Produto");
                Console.WriteLine("[2] Preço do Produto");
                Console.WriteLine("[3] Promoção do Produto");
                Console.WriteLine("[0] Sair");
                escolha = int.Parse(Console.ReadLine());
            
            switch (escolha){
                case 1:
                    Console.WriteLine("Cadrasto Produtos");
                    do
                    {
                        if (produtos < 10)
                        {
                            Console.WriteLine($"Digite o nome do {produtos + 1}°: ");
                            nomes[produtos] = Console.ReadLine();
                            Console.WriteLine("Digite o preço do produto:");
                            nomes[produtos] = Console.ReadLine();
                            Console.WriteLine("Esse produto está em promoção? s/n");
                            resposta = Console.ReadLine();
                            promo[produtos] = Promocao(resposta);
                            produtos++;
                        }else{
                            Console.WriteLine("Limite excedido");
                            break;
                        }
                        Console.WriteLine("Deseja colocar um novo produto? s/n");
                        resposta = Console.ReadLine();                  
                    } while (resposta.ToUpper() == "s");
                break;

                case 2:
                   Console.WriteLine("Lista Produto");
                   for (var i = 0; i < produtos; i++)
                   {
                       Console.WriteLine($"Produto {produto[i]}, Preço {preco[i]} e Promoçao {promo[i]}");
                   }
                    break;

                case 0:
                   Console.WriteLine("Obrigada, volte sempre.");
                    break; 

                default:
                    Console.WriteLine("Inválido");
                    break;
             }
            
            }while(escolha != 0);
        
        //função
        bool Promocao(string promocao){
            
            if (promocao == "s"){
                Console.WriteLine("Tem promocao");
                return true;
            }else{
                Console.WriteLine("sem promocao");
                return false;
            } 
        }     
            
        }

    }
}
            

