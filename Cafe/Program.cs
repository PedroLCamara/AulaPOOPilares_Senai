using System;
using Cafe.classes;

namespace Cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            cafeteira c = new cafeteira();
            bool cafeteiraOn= true;
            string resposta;
            int acucarEspecifico;
            do
            {
                Console.WriteLine($@"
============= Super CafeteiraTabajaras Plus++ =============
Capacidade ------- {c.acucarDisponivel}gr
1----------------- Fazer café
2----------------- Fazer café com açucar especificado (gr)
3----------------- Desligar
");
                resposta= Console.ReadLine();
                if (resposta=="1")
                {
                    c.cafeteiraUsar();
                    cafeteiraOn= true;
                } 
                else if (resposta=="2")
                {
                    Console.WriteLine("Qual a quantidade de açucar desejada?");
                    acucarEspecifico= int.Parse(Console.ReadLine());
                    c.cafeteiraUsar(acucarEspecifico);
                    cafeteiraOn= true;
                }
                else if (resposta=="3")
                {
                    Console.WriteLine("Desligando...");
                    cafeteiraOn= false;
                }
                else
                {
                    Console.WriteLine("Resposta inválida, digite '1' para fazer café, '2' para fazer café com uma quantia específica de açucar e '3' para desligar a cafeteira.");
                    cafeteiraOn= true;
                }
            } while (cafeteiraOn== true);
        }
    }
}
