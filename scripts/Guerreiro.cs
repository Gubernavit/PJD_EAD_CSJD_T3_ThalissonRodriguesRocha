namespace batalha
{
    public class Guerreiro : IPersonagem
    {
        public float vida { get; set; } = 31;
        public int inteligencia = 7;
        public float ataque = 10;
        public float defesa = 7;
        public string classe = "guerreiro";
        bool calculou = false;

        public void Dano(string oponente)
        {
            Console.WriteLine(classe + " atacou " + oponente + ", tirou " + ataque + " de vida");
        }

        public void Inteligencia()
        {
            if (!calculou)
            {
                int rMax = inteligencia / 2;
                Random ataqueR = new Random();
                ataque *= ataqueR.Next(1, rMax + 1);
                Random defesaR = new Random();
                defesa *= defesaR.Next(1, rMax + 1);
                calculou = true;
            }
        }

        public void Ataque(IPersonagem oponente)
        {
            oponente.Vida(ataque);
        }

        public void Defesa()
        {
            Console.WriteLine(classe + " defesa: " + defesa);
        }

        public void Vida(float dano)
        {
            vida -= dano;
            if (vida <= 0)
            {
                Console.WriteLine("Guerreiro tem 0 de vida");
                Console.WriteLine("Guerreiro Morreu, Fim da partida");
                Console.WriteLine("Mago e Barbaro venceram");
                Batalha.morreu = true;
            }
            else
            {
                Console.WriteLine("Guerreiro tem " + vida + " de vida");
            }
        }

        public void Classe()
        {
            Console.WriteLine(classe + " classe: " + classe);
        }

        public void Atributos()
        {
            Console.WriteLine("Classe: " + classe);
            Console.WriteLine("Vida: " + vida);
            Console.WriteLine("Inteligencia: " + inteligencia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Defesa: " + defesa);
        }
    }
}