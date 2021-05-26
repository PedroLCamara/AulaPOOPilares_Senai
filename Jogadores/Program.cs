using System;
using Jogadores.classes;

namespace Jogadores
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respostaCorreta = false;
            string resposta;
            do
            {
                Console.WriteLine(@"Você joga em qual posição?
                1- Ataque
                2- Meio-campo
                3- Defesa");
                resposta = Console.ReadLine();
                if (resposta== "1")
                {
                    jogadorAtaque a = new jogadorAtaque();
                    a.coletarDados();
                    a.calcularIdade();
                    a.calcularAposentadoria();
                    respostaCorreta= true;
                }
                else if (resposta== "2")
                {
                    jogadorMeioCampo m = new jogadorMeioCampo();
                    m.coletarDados();
                    m.calcularIdade();
                    m.calcularAposentadoria();
                    respostaCorreta= true;
                }
                else if (resposta== "3")
                {
                    jogadorDefesa d = new jogadorDefesa();
                    d.coletarDados();
                    d.calcularIdade();
                    d.calcularAposentadoria();
                    respostaCorreta= true;
                }
                else
                {
                    Console.WriteLine("Resposta inválida, digite '1' para Atacante, '2' para meio-Campo e '3' para defensor.");
                    respostaCorreta= false;
                }
            } while (respostaCorreta== false);
        }
    }
}
