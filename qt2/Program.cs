using System;

namespace PontuacaoJogadorApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Digite o número de inimigos derrotados: ");
            int inimigosDerrotados = int.Parse(Console.ReadLine());

            
            Console.Write("Digite a duração da batalha em minutos: ");
            int duracaoBatalha = int.Parse(Console.ReadLine());

            
            Console.Write("O jogador sofreu danos críticos? (sim ou não): ");
            string sofreuDanoCritico = Console.ReadLine().Trim().ToLower();

            
            int pontuacaoBase = inimigosDerrotados * 100;

           
            int descontoPorTempo = duracaoBatalha * 10;

           
            double multiplicadorCritico = (sofreuDanoCritico == "sim") ? 0.8 : 1.0;

           
            double pontuacaoFinal = (pontuacaoBase - descontoPorTempo) * multiplicadorCritico;

           
            pontuacaoFinal = Math.Max(pontuacaoFinal, 0);

            
            Console.WriteLine($"\nPontuação Final do Jogador: {pontuacaoFinal}");
        }
    }
}
