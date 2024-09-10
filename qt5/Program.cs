using System;

namespace DecisaoJogadorApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Digite a porcentagem de vida do jogador (0 a 100): ");
            int vidaJogador = int.Parse(Console.ReadLine());

           
            Console.Write("Digite o número de armadilhas conhecidas no caminho: ");
            int armadilhas = int.Parse(Console.ReadLine());

           
            Console.Write("Digite a distância do aliado em metros: ");
            int distanciaAliado = int.Parse(Console.ReadLine());

           
            if (vidaJogador > 50 && armadilhas < 3)
            {
                Console.WriteLine("Seguir em frente.");
            }
            else if (vidaJogador < 50 && armadilhas < 2 && distanciaAliado < 10)
            {
                Console.WriteLine("Tentar resgate rápido.");
            }
            else
            {
                Console.WriteLine("Recuar.");
            }
        }
    }
}
