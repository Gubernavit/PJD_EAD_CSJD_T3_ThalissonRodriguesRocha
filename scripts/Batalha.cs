using batalha;  
namespace batalha
{
    public class Batalha
    {
        public static bool morreu = false;

        public void Arena(string classe)
        {
            IPersonagem Jogador = null!;
            IPersonagem Oponente1 = null!;
            IPersonagem Oponente2 = null!;
            IPersonagem oponente = null!;
            IPersonagem Alvo = null!;

            string arma = "uma Arma";
            string opcao;
            int dado;
            int rand;
            bool turnoJogador = false;
            int opcaoconvertida;
            int cont = 1;
            int rodada = 1;

            string alvo = "voce";
            string jogador = "player";
            string oponente1 = "oponente1";
            string oponente2 = "oponente2";

            Random random = new Random();

            switch (classe)
            {
                case "Mago":
                    arma = "o Cajado Magico";

                    jogador = "Mago";
                    oponente1 = "Guerreiro";
                    oponente2 = "Barbaro";

                    Jogador = new Mago();
                    Oponente1 = new Guerreiro();
                    Oponente2 = new Barbaro();
                break;

                case "Guerreiro":
                    arma = "as Laminas do CAOS e um Escudo";

                    jogador = "Guerreiro";
                    oponente1 = "Mago";
                    oponente2 = "Barbaro";

                    Jogador = new Guerreiro();
                    Oponente1 = new Mago();
                    Oponente2 = new Barbaro();
                break;

                case "Barbaro":
                    arma = "um Machado Enferrujado e seus Punhos de Ferro";

                    jogador = "Barbaro";
                    oponente1 = "Guerreiro";
                    oponente2 = "Mago";

                    Jogador = new Barbaro();
                    Oponente1 = new Guerreiro();
                    Oponente2 = new Mago();
                break;

            }

            if (Jogador == null || Oponente1 == null || Oponente2 == null)
            {
                Console.WriteLine("ERRO: Uma ou mais classes invalidas. (script: Batalha)");
                return;
            }
                
            Console.WriteLine("=====================================ARENA========================================");
            Console.WriteLine("Sua classe e: " + classe);
            Console.WriteLine("Voce tem " + arma + " como arma");
            Console.WriteLine("Vamos ver quem comeca, escolha um numero entre 1 e 6: ");

            opcao = Console.ReadLine().ToLower().Replace(" ", "");
            
            if (!int.TryParse(opcao, out opcaoconvertida)) 
            {
                Console.WriteLine("Entrada invalida, assumindo 1.");
                opcaoconvertida = 1;
            }

            dado = random.Next(1, 7);

            if (opcaoconvertida == dado)
            {
                Console.WriteLine("O dado rolou e parou com o " + dado + " virado pra cima, voce comeca");
                Console.WriteLine("==================================================================================");
                turnoJogador = true;
            }
            else
            {
                Console.WriteLine("O dado rolou e parou com o " + dado + " virado pra cima, oponente comeca");
                Console.WriteLine("==================================================================================");
            }

            while (!morreu)
            {
                if (turnoJogador && !morreu)
                {
                     Console.WriteLine("===================================RODADA-"+ rodada +"=======================================");
                }
                while (turnoJogador && !morreu)
                {
                    Console.WriteLine("\nEscolha quem vai atacar");
                    Console.WriteLine("(1) " + oponente1);
                    Console.WriteLine("(2) " + oponente2);

                    opcao = Console.ReadLine().ToLower().Replace(" ", "");

                    if (opcao == "1" || opcao.Replace("mago","Mago").Replace("guerreiro", "Guerreiro") == oponente1)
                    {
                        oponente1.Replace("Mago","mago").Replace("Guerreiro","guerreiro");
                        Jogador.Dano(oponente1);
                        Jogador.Ataque(Oponente1);
                        Console.WriteLine("==================================================================================");
                        cont++;
                    }
                    else if (opcao == "2" || opcao.Replace("mago","Mago").Replace("barbaro", "Barbaro") == oponente2)
                    {
                        oponente2.Replace("Mago","mago").Replace("Barbaro","barbaro");
                        Jogador.Dano(oponente2);
                        Jogador.Ataque(Oponente2);
                        Console.WriteLine("==================================================================================");
                        cont++;
                    }
                    else
                    {
                        Console.WriteLine("Opcao invalida, tente novamente.");
                        Console.WriteLine("==================================================================================");
                    }
                    if(cont >= 3)
                    {
                        rodada += 1;
                        cont = 1;
                        turnoJogador = false;
                    }
                }
                if(!turnoJogador && !morreu)
                {
                    dado = random.Next(1, 3);

                    Console.WriteLine("===================================RODADA-"+ rodada +"=======================================");
                    for(int i = 0; i < 2 && !morreu; i++)
                    {
                        rand = random.Next(1, 4);
    
                        if (dado == 2)
                        {
                            oponente = Oponente1;
                        }
                        else if(dado != 2)
                        {
                            oponente = Oponente2;
                        }

                        if (rand == 1)
                        {
                            alvo = oponente1;
                            Alvo = Oponente1;
                        }
                        else if(rand == 2)
                        {
                            alvo = oponente2;
                            Alvo = Oponente2;
                        }
                        else if(rand == 3)
                        {
                            alvo = jogador;
                            Alvo = Jogador;
                        }
                        oponente.Dano(alvo);
                        oponente.Ataque(Alvo);
                        Console.WriteLine("==================================================================================");
                        cont++;
                    }

                    rodada += 1;
                    Console.WriteLine("===================================RODADA-"+ rodada +"=======================================");
                    for(int i = cont; i >= 3 && i < 5  && !morreu; i++)
                    {
                        rand = random.Next(1, 4);

                        if (dado != 2)
                        {
                            oponente = Oponente1;
                        }
                        else if(dado == 2)
                        {
                            oponente = Oponente2;
                        }

                        if (rand == 1)
                        {
                            alvo = oponente1;
                            Alvo = Oponente1;
                        }
                        else if(rand == 2)
                        {
                            alvo = oponente2;
                            Alvo = Oponente2;
                        }
                        else if(rand == 3)
                        {
                            alvo = jogador;
                            Alvo = Jogador;
                        }
                        oponente.Dano(alvo);
                        oponente.Ataque(Alvo);
                        Console.WriteLine("==================================================================================");
                    }
                    cont = 0;
                    rodada += 1;
                    turnoJogador = true;
                }
            }
        }
    }
}