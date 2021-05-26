using System;

namespace Elevador.classes
{
    public abstract class  elevador
    {
        public int andarAtual {get; set;} = 0;
        public int numeroAndares {get; set;}
        public int quantidadePessoas {get; set;} = 0;
        public int capacidadePessoas {get; set;}

        public void Inicializar(){
            Console.WriteLine("Qual é o número de andares do prédio?(desconsiderando o térreo)");
            numeroAndares = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas pessoas podem entrar no elevador por vez?");
            capacidadePessoas = int.Parse(Console.ReadLine());
        }
        public void Entrar(){
            if (quantidadePessoas < capacidadePessoas)
            {
                quantidadePessoas ++;
                Console.WriteLine($"Uma pessoas entrou, agora o elevador conta com {quantidadePessoas}");
            }
            else
            {
                Console.WriteLine($"O elevador está em sua capacidade máxima!!! Não há como entrar mais que {quantidadePessoas} pessoas!!!!!!");
            }
        }
        public void Sair(){
            if (quantidadePessoas > 0)
            {
                quantidadePessoas --;
                Console.WriteLine($"Uma pessoas saiu, agora o elevador conta com {quantidadePessoas}");
            }
            else
            {
                Console.WriteLine($"O elevador já está sem ninguém!!!");
            }
        }
        public void Subir(){
            if (andarAtual < numeroAndares)
            {
                andarAtual++;
                Console.WriteLine($"O elevador subiu um andar, agora se encontra no andar {andarAtual}");
            }
            else{
                Console.WriteLine($"Já está no andar {andarAtual}!!! Não há mais andares para subir!!!!!!");
            }
        }
        public void Descer(){
            if (andarAtual > 0)
            {
                andarAtual--;
                Console.WriteLine($"O elevador desceu um andar, agora se encontra no andar {andarAtual}");
            }
            else{
                Console.WriteLine($"Já está no térreo!!! Não há subsolo configurado para este elevador!!!!!!");
            }
        }
        public virtual void Status(){
            Console.WriteLine($"Nº de pessoas: {quantidadePessoas}");
            Console.WriteLine($"Andar atual: {andarAtual}");
        }
    }
}