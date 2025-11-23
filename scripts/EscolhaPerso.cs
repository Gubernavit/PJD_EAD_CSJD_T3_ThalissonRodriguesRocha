using batalha;  

namespace batalha
{
    public class EscolhaPersonagem
    {
        public void Escolha()
        {
            string opcao;
            bool escolhendo = true;

            Batalha batalha = new Batalha();

            IPersonagem mago = new Mago();
            IPersonagem guerreiro = new Guerreiro();
            IPersonagem barbaro = new Barbaro();

            while (escolhendo)
            {
                Console.WriteLine("Escolha seu personagem: ");
                Console.WriteLine("(1) Mago");
                Console.WriteLine("(2) Guerreiro");
                Console.WriteLine("(3) Barbaro");

                opcao = Console.ReadLine().ToLower().Replace(" ", "");

                if (opcao == "1" || opcao == "mago")
                {
                    Console.WriteLine("===================================ATRIBUTOS======================================");
                    mago.Atributos();

                    Console.WriteLine("\nTEM CERTEZA? (s/n)");
                    opcao = Console.ReadLine().ToLower().Replace(" ", "");

                    if (opcao == "s" || opcao == "sim")
                    {
                        Console.WriteLine("==================================================================================");
                        batalha.Arena("Mago");
                        escolhendo = false;
                    }
                    else if (opcao == "n" || opcao == "nao")
                    {
                        Console.WriteLine("==================================================================================");
                    }
                    else
                    {
                        Console.WriteLine("Opcao invalida");
                        Console.WriteLine("==================================================================================");
                    }
                }
                else if (opcao == "2" || opcao == "guerreiro")
                {
                    Console.WriteLine("===================================ATRIBUTOS======================================");
                    guerreiro.Atributos();

                    Console.WriteLine("\nTEM CERTEZA? (s/n)");
                    opcao = Console.ReadLine().ToLower().Replace(" ", "");

                    if (opcao == "s" || opcao == "sim")
                    {
                        Console.WriteLine("==================================================================================");
                        batalha.Arena("Guerreiro");
                        escolhendo = false;
                    }
                    else if (opcao == "n" || opcao == "nao")
                    {
                        Console.WriteLine("==================================================================================");
                    }
                    else
                    {
                        Console.WriteLine("Opcao invalida");
                        Console.WriteLine("==================================================================================");
                    }
                }
                else if (opcao == "3" || opcao == "barbaro")
                {
                    Console.WriteLine("===================================ATRIBUTOS======================================");
                    barbaro.Atributos();

                    Console.WriteLine("\nTEM CERTEZA? (s/n)");
                    opcao = Console.ReadLine().ToLower().Replace(" ", "");

                    if (opcao == "s" || opcao == "sim")
                    {
                        Console.WriteLine("==================================================================================");
                        batalha.Arena("Barbaro");
                        escolhendo = false;
                    }
                    else if (opcao == "n" || opcao == "nao")
                    {
                        Console.WriteLine("==================================================================================");
                    }
                    else
                    {
                        Console.WriteLine("Opcao invalida");
                        Console.WriteLine("==================================================================================");
                    }
                }
                else
                {
                    Console.WriteLine("Opcao invalida");
                    Console.WriteLine("==================================================================================");
                }
            }
        }
    }
}