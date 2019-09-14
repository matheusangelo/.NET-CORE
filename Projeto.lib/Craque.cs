using Projeto.Interface;

namespace Projeto.lib
{
    public class Craque : IJogador
    {
        public string Chutar()
        {
            return "O Craque Chutou";
        }

        public string Correr()
        {
            return "O Craque Correu";
        }
    }
}