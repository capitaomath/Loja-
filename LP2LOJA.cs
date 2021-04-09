using System;
using System.Collections.Generic;



public class Item
{
    public string Nome;
    public int Id;
    public int Preco;
    public string Desc;
}



public class Player
{
    public string nome;
    public int xp;
    public int gold;
    public List<Item> Itens = new List<Item>();
}



public class LP2_Trabalho
{

 
 
    static List<Player> Jogadores = new List<Player>();

    public static void Main(string[] args)
    {
       
        
        bool MostrarMenu = true;
        while (MostrarMenu)
        {
            MostrarMenu = MenuPrincipal();
        }

    }


    private static bool MenuPrincipal()
    {

            Item Espada_De_Ferro = new Item();
            Espada_De_Ferro.Id = 1;
            Espada_De_Ferro.Nome = "Espada de Ferro";
            Espada_De_Ferro.Preco = 40;
            Espada_De_Ferro.Desc = "(+12% DESTREZA)";

            Item Espada_De_Ouro = new Item();
            Espada_De_Ouro.Id = 2;
            Espada_De_Ouro.Nome = "Espada De Ouro";
            Espada_De_Ouro.Preco = 100;
            Espada_De_Ouro.Desc = "(+20% DANO DE ATAQUE)";

            Item Machado_de_aço_Valyrian = new Item();
            Machado_de_aço_Valyrian.Id = 3;
            Machado_de_aço_Valyrian.Nome = "Machado de aço Valyrian";
            Machado_de_aço_Valyrian.Preco = 50;
            Machado_de_aço_Valyrian.Desc = "(+50% DANO DE ATAQUE)";

            Item Armadura_De_Ferro = new Item();
            Armadura_De_Ferro.Id = 4;
            Armadura_De_Ferro.Nome = "Armadura de Ferro";
            Armadura_De_Ferro.Preco = 20;
            Armadura_De_Ferro.Desc = "(+20% PROTEÇÃO)";

            Item Cajado_Leviata = new Item();
            Cajado_Leviata.Id = 5;
            Cajado_Leviata.Nome = "Cajado Leviatã";
            Cajado_Leviata.Preco = 75;
            Cajado_Leviata.Desc = "(+90% CHANCE DE ACERTO CRÍTICO, DANO MÁGICO)";


       


        Console.Clear();
        Console.WriteLine("==================================================================");
        Console.WriteLine("Entre com '1' para criar um jogador.");
        Console.WriteLine("Entre com '2' para ver os jogadores criados.");
        Console.WriteLine("Entre com '3' para olhar o inventário.");
        Console.WriteLine("Entre com '4' para entrar na loja.");
        Console.WriteLine("Entre com '5' para encerrar o programa.");
        Console.WriteLine("==================================================================");
        switch (Console.ReadLine())
        {




            case "1":

                Console.Clear();  
                
                Console.Write("Insira um Apelido : ");
                var NomeJogador = Console.ReadLine();
                NomeJogador = NomeJogador.ToLower();


                Console.Write("Insira uma quantidade de experiência: ");
                var EXP = Console.ReadLine();
               
                Random GetEXP = new Random();
                var Moedas = GetEXP.Next(50, 350);


                Jogadores.Add(new Player { nome = NomeJogador, xp = Convert.ToInt32(EXP), gold = Moedas});
                Console.Clear();
                Console.WriteLine("Jogador criado com sucesso");
                Console.WriteLine("");
                Console.WriteLine("Adicionamos moedas" + Moedas  + " de ouro na sua conta");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.Read();
            return true;







            case "2":
                Console.Clear();
                for (int i = 0; i < Jogadores.Count; i++)
                {

                    Console.WriteLine("");
                    Console.WriteLine("Jogador:");            
                    Console.WriteLine("Nickname : " + Jogadores[i].nome);
                    Console.WriteLine("Experiência : " + Jogadores[i].xp);
                    Console.WriteLine("Ouro : " + Jogadores[i].gold);                 
                    Console.WriteLine("");
                }

                Console.WriteLine("");
                Console.Write("Pressione qualquer tecla para sair...");
                Console.ReadKey();
            return true;
            





            case "3":
            Console.Clear();
            Console.WriteLine("Digite o nome do jogador para verificar o iventário:");
            var NomeJogador0 = Console.ReadLine();
            NomeJogador0 = NomeJogador0.ToLower();
            foreach(Player p in Jogadores)
            {
                if(p.nome == NomeJogador0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Itens:");
                    Console.WriteLine("");
                    for (int i = 0; i < p.Itens.Count; i++)
                    {
                        Console.WriteLine("Item: " + p.Itens[i].Nome);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Entre com qualquer tecla para continuar");
                    Console.Read();
                }
                else{
                    Console.Clear();
                    Console.WriteLine("Nenhum jogador encontrado... Retornando ao menu principal");
                    Console.Read();
                }
            }
            return true;





            case "4":
            Console.Clear();
            Console.WriteLine("Digite o nome do jogador que vai acessar a loja: ");
            NomeJogador0 = Console.ReadLine();
            NomeJogador0 = NomeJogador0.ToLower();
            foreach(Player p in Jogadores)
            {
                if(p.nome == NomeJogador0)
                {       
                    Console.WriteLine("- Insira o ID do item que você espera comprar:");
                    Console.WriteLine("");
                    Console.WriteLine(Espada_De_Ferro.Id + " - " + Espada_De_Ferro.Nome  + " " + Espada_De_Ferro.Desc);
                    Console.WriteLine("");
                    Console.WriteLine(Espada_De_Ouro.Id + " - " + Espada_De_Ouro.Nome  + " " + Espada_De_Ouro.Desc);
                    Console.WriteLine("");
                    Console.WriteLine(Machado_de_aço_Valyrian.Id + " - " + Machado_de_aço_Valyrian.Nome  + " " + Machado_de_aço_Valyrian.Desc);
                    Console.WriteLine("");
                    Console.WriteLine(Armadura_De_Ferro.Id + " - " + Armadura_De_Ferro.Nome  + " " + Armadura_De_Ferro.Desc);
                    Console.WriteLine("");
                    Console.WriteLine(Cajado_Leviata.Id + " - " + Cajado_Leviata.Nome + " " + Cajado_Leviata.Desc);       
                    Console.WriteLine("");
                    var ic = Console.ReadLine();
                 
                 
          

                    if( ic == Espada_De_Ferro.Id.ToString() ){

                        Console.WriteLine("Você gostaria de comprar " + Espada_De_Ferro.Nome + " por " + Espada_De_Ferro.Preco + "G? (S)/(N)");
                        Console.WriteLine("Seu ouro:" + p.gold);
                        var resp = Console.ReadLine();
                        if(resp == "s")
                        {
                            if(p.gold >= Espada_De_Ferro.Preco)
                            {
                                p.gold = p.gold - Espada_De_Ferro.Preco;
                                p.Itens.Add(Espada_De_Ferro);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao iventário com sucesso!");
                               Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                               else
                            {
                                Console.WriteLine("Saldo insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                        }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            } 
                    }


                    else if(ic == Espada_De_Ouro.Id.ToString())
                    {
                        Console.WriteLine("Você gostaria de comprar " + Espada_De_Ouro.Nome + " por " + Espada_De_Ouro.Preco + "G? (S)/(N)");
                        Console.WriteLine("Seu ouro:" + p.gold);              
                         var resp = Console.ReadLine();
                        if(resp == "s")
                        {
                            if(p.gold >= Espada_De_Ouro.Preco)
                            {
                                p.gold = p.gold - Espada_De_Ouro.Preco;
                                p.Itens.Add(Espada_De_Ouro);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao iventário com sucesso!");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                        }
                              else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           } 
                    }


                    else if(ic == Machado_de_aço_Valyrian.Id.ToString())
                    {

                       Console.WriteLine("Você gostaria de comprar " + Machado_de_aço_Valyrian.Nome + " por " + Machado_de_aço_Valyrian.Preco + "G? (S)/(N)");
                       Console.WriteLine("Seu ouro:" + p.gold);
                       var resp = Console.ReadLine();
                       resp = resp.ToLower();
                        if(resp == "s" )
                        {
                            if(p.gold >= Machado_de_aço_Valyrian.Preco)
                            {
                                p.gold = p.gold - Machado_de_aço_Valyrian.Preco;
                                p.Itens.Add(Machado_de_aço_Valyrian);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao iventário com sucesso!");
                                 Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                        }
                         else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           } 
                    }


                    else if(ic == Armadura_De_Ferro.Id.ToString())
                    {
                       Console.WriteLine("Você gostaria de comprar " + Armadura_De_Ferro.Nome + " por " + Armadura_De_Ferro.Preco + "G? (S)/(N)");
                       Console.WriteLine("Seu ouro:" + p.gold);
                       var resp = Console.ReadLine();
                         resp = resp.ToLower();
                        if(resp == "s")
                        {
                            if(p.gold >= Armadura_De_Ferro.Preco)
                            {
                                p.gold = p.gold - Armadura_De_Ferro.Preco;
                                p.Itens.Add(Armadura_De_Ferro);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao iventário com sucesso!");
                                 Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                           else
                            {
                                Console.WriteLine("Saldo insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                        }
                             else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           } 
                    }



                     else if(ic == Cajado_Leviata.Id.ToString())
                    {

                        Console.WriteLine("Você gostaria de comprar " + Cajado_Leviata.Nome + " por " + Cajado_Leviata.Preco + "G? (S)/(N)");
                        Console.WriteLine("Seu ouro:" + p.gold);
                       var resp = Console.ReadLine();
                         resp = resp.ToLower();
                        if(resp == "s")
                        {
                            if(p.gold >= Cajado_Leviata.Preco)
                            {
                                p.gold = p.gold - Cajado_Leviata.Preco;
                                p.Itens.Add(Cajado_Leviata);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao iventário com sucesso!");    
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                            else
                            {

                                Console.WriteLine("Saldo insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                        }
                        else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           } 
                    }


                    else{
                    Console.Clear();
                    Console.WriteLine("Nenhum jogador encontrado...");
                    Console.WriteLine("Insira qualquer tecla para retornar ao menu principal...");
                    Console.ReadLine();
                    }

                   

                 }
            }
             return true;


            case "5":
                return false;


            default:
                return true;

        }
    
    }






}