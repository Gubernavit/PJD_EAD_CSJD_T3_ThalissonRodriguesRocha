namespace batalha
{
    public class Barbaro : IPersonagem
    {
        public float vida { get; set; } = 37;
        public int inteligencia = 0;
        public float ataque = 15;
        public float defesa = 10;
        public string classe = "barbaro";

        public void Dano(string oponente)
        {
            Console.WriteLine(classe + " atacou " + oponente + ", tirou " + ataque + " de vida");
        }

        public void Inteligencia()
        {
            Console.WriteLine(classe + " inteligencia: " + inteligencia);
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
                Console.WriteLine("Barbaro tem 0 de vida");
                Console.WriteLine("Barbaro Morreu, Fim da partida");
                Console.WriteLine("Guerreiro e Mago venceram");
                Batalha.morreu = true;
            }
            else
            {
                Console.WriteLine("Barbaro tem " + vida + " de vida");
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