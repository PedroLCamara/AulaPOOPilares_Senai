using System;

namespace Elevador.classes
{
    public class elevadorServico : elevador
    {
        public int quantidadeCaixas {get; set;} = 0;
        public void adicionarCaixa(){
            quantidadeCaixas ++;
            Console.WriteLine($"O elevador conta agora com {quantidadeCaixas} caixas");
        }
        public void removerCaixa(){
            if (quantidadeCaixas > 0)
            {    
            quantidadeCaixas --;
            Console.WriteLine($"O elevador conta agora com {quantidadeCaixas} caixas");
            }
            else{
                Console.WriteLine("Não há caixas para remover.");
            }
        }
        public override void Status()
        {
            base.Status();
            Console.WriteLine($"Nº de caixas {quantidadeCaixas}");
        }
    }
}