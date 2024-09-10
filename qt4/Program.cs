using System;

namespace AtaqueEspecialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite a quantidade de mana do jogador: ");
            int mana = int.Parse(Console.ReadLine());

           
            Console.Write("Digite a vida atual do inimigo em porcentagem (0 a 100): ");
            int vidaInimigo = int.Parse(Console.ReadLine());

            
            Console.Write("Digite o nível do jogador: ");
            int nivelJogador = int.Parse(Console.ReadLine());

           
            bool podeRealizarAtaqueEspecial = (mana > 30) && (vidaInimigo < 50) && (nivelJogador > 5);

           
            if (podeRealizarAtaqueEspecial)
            {
                Console.WriteLine("Você pode realizar o ataque especial!");
            }
            else
            {
                Console.WriteLine("Você não pode realizar o ataque especial.");
            }
        }
    }
}
