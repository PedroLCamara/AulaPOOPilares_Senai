using System;

namespace Jogadores.classes
{
    public class jogadorDefesa : jogador
    {
        public override void calcularAposentadoria()
        {
            int idadeAposentar= 40;
            Console.WriteLine($"faltam {(idadeAposentar-idade)} anos para se aposentar");
        }
    }
}