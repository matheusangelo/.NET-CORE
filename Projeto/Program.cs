using Projeto.lib;

namespace Projeto {
    class Program {
        static void Main (string[] args) {
            Jogo a = new Jogo (new Jogador ("Ronaldo"));
            Jogo b = new Jogo (new Craque ());
            a.IniciarJogo ();
            b.IniciarJogo ();
        }
    }
}