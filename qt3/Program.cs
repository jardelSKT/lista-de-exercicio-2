using System;

namespace CalculoPrecoPocoesApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Digite a classe do jogador (Guerreiro, Mago, Paladino): ");
            string classe = Console.ReadLine().Trim().ToLower();

            
            Console.Write("Digite o tipo de poção (Vida, Mana, Resistência): ");
            string tipoPocao = Console.ReadLine().Trim().ToLower();

           
            Console.Write("Digite a quantidade de poções que deseja comprar: ");
            int quantidade = int.Parse(Console.ReadLine());

           
            double precoVida = 50.0;
            double precoMana = 30.0;
            double precoResistencia = 40.0;

           
            double precoPocao = 0.0;
            double desconto = 0.0;

            switch (tipoPocao)
            {
                case "vida":
                    precoPocao = precoVida;
                    if (classe == "guerreiro")
                    {
                        desconto = 0.10; 
                    }
                    break;

                case "mana":
                    precoPocao = precoMana;
                    if (classe == "mago")
                    {
                        desconto = 0.15;
                    }
                    break;

                case "resistência":
                    precoPocao = precoResistencia;
                    if (classe == "paladino")
                    {
                        desconto = 0.20; 
                    }
                    break;

                default:
                    Console.WriteLine("Tipo de poção desconhecido.");
                    return;
            }

            
            double precoTotalSemDesconto = precoPocao * quantidade;

            
            double precoTotalComDesconto = precoTotalSemDesconto * (1 - desconto);

            
            Console.WriteLine($"\nPreço total sem desconto: {precoTotalSemDesconto:F2} unidades de moeda");
            Console.WriteLine($"Preço total com desconto: {precoTotalComDesconto:F2} unidades de moeda");
        }
    }
}
