using System;
using Elevador.classes;

namespace Elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            elevadorServico se = new elevadorServico();
            elevadoSocial so = new elevadoSocial();
            se.Inicializar();
            so.capacidadePessoas = se.capacidadePessoas;
            so.numeroAndares = se.numeroAndares;
            string resposta;
            bool predio = true;
            bool elevadorX = true;
            do
            {
            Console.WriteLine(@"Qual elevador você deseja utilizar?
            1- Elevador social
            2- Elevador de serviço
            3- DEMOLIR O PRÉDIO");
            resposta = Console.ReadLine();
            if (resposta == "1")
            {
                do
                {
                    Console.WriteLine(@"O que deseja fazer no elevador social?
                    1- Subir
                    2- Descer
                    3- Entrar pessoas
                    4- Sair pessoa
                    5- Status
                    6- Voltar a seleção de elevadores");
                    resposta = Console.ReadLine();
                    if (resposta == "1")
                    {
                        so.Subir();
                        elevadorX= true;
                    }
                    else if (resposta == "2")
                    {
                        so.Descer();
                        elevadorX= true;
                    } 
                    else if (resposta == "3")
                    {
                        so.Entrar();
                        elevadorX= true;
                    }
                    else if (resposta == "4")
                    {
                        so.Sair();
                        elevadorX= true;
                    }
                    else if(resposta=="5"){
                        so.Status();
                        elevadorX= true;
                    }
                    else if (resposta == "6")
                    {
                        Console.WriteLine("Voltando a seleção de elevadores...");
                        elevadorX= false;
                    }
                    else
                    {
                        Console.WriteLine("Resposta inválida. Digite '1' para Subir um andar, '2' para descer um andar, '3' para que uma pessoa entre, '4' para que uma pessoa saia, '5' para verificr o status do elevador e '6' para retornar a seleção de elevadores.");
                        elevadorX= true;
                    }
                } while (elevadorX== true);
            } 
            else if (resposta == "2")
            {
                do
                {
                    Console.WriteLine(@"O que deseja fazer no elevador social?
                    1- Subir
                    2- Descer
                    3- Entrar pessoas
                    4- Sair pessoa
                    5- Adicionar caixa
                    6- Remover caixa
                    7- Status
                    8- Voltar a seleção de elevadores");
                    resposta = Console.ReadLine();
                    if (resposta == "1")
                    {
                        se.Subir();
                        elevadorX= true;
                    }
                    else if (resposta == "2")
                    {
                        se.Descer();
                        elevadorX= true;
                    } 
                    else if (resposta == "3")
                    {
                        se.Entrar();
                        elevadorX= true;
                    }
                    else if (resposta == "4")
                    {
                        se.Sair();
                        elevadorX= true;
                    }
                    else if (resposta=="5")
                    {
                        se.adicionarCaixa();
                        elevadorX= true;
                    }
                    else if (resposta=="6")
                    {
                        se.removerCaixa();
                        elevadorX= true;
                    }
                    else if(resposta=="7"){
                        se.Status();
                        elevadorX= true;
                    }
                    else if (resposta == "8")
                    {
                        Console.WriteLine("Voltando a seleção de elevadores...");
                        elevadorX= false;
                    }
                    else
                    {
                        Console.WriteLine("Resposta inválida. Digite '1' para Subir um andar, '2' para descer um andar, '3' para que uma pessoa entre, '4' para que uma pessoa saia, '5' para adicionar uma caixa, '6' para retirar uma caixa, '7' para verificr o status do elevador e '8' para retornar a seleção de elevadores.");
                        elevadorX= true;
                    }
                } while (elevadorX== true);
            }
            else if (resposta == "3")
            {
                Console.WriteLine("Prédio demolido, portanto os elevadores não existem mais.");
                predio = false;
            }
            else
            {
                Console.WriteLine("Resposta inválida. Digite '1' para usar o elevador social, '2' para o elevador de serviço e '3' para demolir o prédio.");
                predio = true;
            }
            } while (predio== true);
        }
    }
}
