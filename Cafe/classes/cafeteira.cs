using System;

namespace Cafe.classes
{
    public class cafeteira
    {
        public int acucarDisponivel= 3000;

        public void cafeteiraUsar(){
            if (acucarDisponivel >= 10)
            {
                acucarDisponivel= acucarDisponivel-10;
                Console.WriteLine("O cafézinho estã servido!");
            }
            else if (acucarDisponivel > 0)
            {
                acucarDisponivel= 0;
                Console.WriteLine("O cafézinho está servido! Porém, com menos açucar que o normal...");
            }
            else
            {
                Console.WriteLine("O cafézinho está servido! Porém, sem açucar...");
            }
        }
        public void cafeteiraUsar(int acucar){
            if (acucar > acucarDisponivel)
            {
                Console.WriteLine("Não há açucar disponível para tal cafézinho!!!");     
            }
            else{
                acucarDisponivel= acucarDisponivel - acucar;
                Console.WriteLine("O cafézinho está servido!");
            }
        }
    }
}