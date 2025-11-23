namespace batalha
{
    public interface IPersonagem
    {
        float vida { get; set; }  

        void Dano(string oponente);
        void Inteligencia();
        void Ataque(IPersonagem oponente);
        void Defesa();
        void Vida(float dano);
        void Classe();
        void Atributos();
    }
}