using System;

namespace Jogadores.classes
{
    public class jogadorMeioCampo : jogador
    {
        public override void calcularAposentadoria()
        {
            int idadeAposentar= 38;
            Console.WriteLine($"faltam {(idadeAposentar-idade)} anos para se aposentar");
        }
    }
}