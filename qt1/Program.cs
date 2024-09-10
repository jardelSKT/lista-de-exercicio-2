using System;

namespace VerificacaoArmaduraApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Digite a classe do personagem (Guerreiro, Mago, Arqueiro): ");
            string classe = Console.ReadLine().Trim().ToLower();

            
            Console.Write("Digite o valor de defesa da armadura: ");
            int defesaArmadura = int.Parse(Console.ReadLine());

           
            Console.Write("Digite a penalidade de agilidade da armadura: ");
            int penalidadeAgilidade = int.Parse(Console.ReadLine());

            
            bool armaduraAdequada = false;

            switch (classe)
            {
                case "guerreiro":
                    
                    if (defesaArmadura >= 50 && penalidadeAgilidade <= 10)
                    {
                        armaduraAdequada = true;
                    }
                    break;

                case "mago":
                   
                    if (defesaArmadura >= 30 && defesaArmadura < 50 && penalidadeAgilidade <= 5)
                    {
                        armaduraAdequada = true;
                    }
                    break;

                case "arqueiro":
                   
                    if (defesaArmadura >= 30 && defesaArmadura < 50 && penalidadeAgilidade < 5)
                    {
                        armaduraAdequada = true;
                    }
                    break;

                default:
                    Console.WriteLine("Classe desconhecida.");
                    break;
            }

          
            if (armaduraAdequada)
            {
                Console.WriteLine("A armadura é adequada para a classe.");
            }
            else
            {
                Console.WriteLine("A armadura não é adequada para a classe.");
            }
        }
    }
}
