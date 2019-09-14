using System;
using Projeto.Interface;

namespace Projeto.lib {


    public class Jogador:IJogador {
        private readonly string nome;
        public Jogador (string nome) {
            this.nome = nome;
        }

        public string Correr () {
            return ($"\n {this.nome} Está Correndo");
        }

        public string Chutar () {
            return ($"\n {this.nome} Está Chutando");
        }

    }
}