using System;

namespace Jogadores.classes
{
    public abstract class jogador
    {
        protected string nome;
        public int anoNascimento;
        protected string nacionalidade;
        protected string altura;
        protected string peso;
        public int idade;
        public void coletarDados(){
            Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual é o seu ano de nascimento?");
            anoNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a sua nacionalidade?");
            nacionalidade = Console.ReadLine();
            Console.WriteLine("Qual é a sua altura?");
            altura = Console.ReadLine();
            Console.WriteLine("Qual é o seu peso?");
            peso = Console.ReadLine();
        }
        public void calcularIdade(){
            idade = DateTime.Now.Year - anoNascimento;
        }
        public virtual void calcularAposentadoria(){
            int idadeAposentar= 0;
            Console.WriteLine($"faltam {(idadeAposentar-idade)} anos para se aposentar");
        }
    }
}