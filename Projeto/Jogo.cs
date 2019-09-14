using System;
using Projeto.Interface;

namespace Projeto {
    public class Jogo {
        private readonly IJogador jogador;

        //recebendo a classe com a interface
        public Jogo (IJogador jogador) {
            this.jogador = jogador;
        }

        public void IniciarJogo () {
            Console.Write(jogador.Correr());
            Console.Write(jogador.Chutar());
        }
    }

}