using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Neymar está chutando\n";
        }

        public string Corre()
        {
            return "Neymar está correndo\n";
        }

        public string Passe()
        {
            return "Neymar está passando\n";
        }
    }
}