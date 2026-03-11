
using System;
using System.Security.Cryptography;

class Program
{

    
    static void Main(string[] args)
    {
        while (true)
        {   
            int[]numDigitados = new int[100]; 
            int countNumDigitados = 0;
            int starPoint = 1000;
            
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Jogo de Advinhação!");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Escolha o nivel de dificuldade:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1 - Fácil (10 tentativas)");
            Console.WriteLine("2 - Médio (5 tentativas)");
            Console.WriteLine("3 - Difícil (3 tentativas)");
            Console.WriteLine("------------------------------");
            
            Console.WriteLine("Digite sua scolha: ");
            int dificuldade = Convert.ToInt32(Console.ReadLine());
            
            int numMax;
            int tentativasMax;

            switch (dificuldade)
            {
                case 1:
                    numMax = 20;
                    tentativasMax = 10;
                    break;
                case 2:
                    numMax = 50;
                    tentativasMax = 5;
                    break;
                case 3:
                    numMax = 100;
                    tentativasMax = 3;
                    break;
                default:
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Nível de dificuldade inválido!");
                    Console.WriteLine("Digite ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
            }

            
            int numeroAleatorio = RandomNumberGenerator.GetInt32(1, numMax + 1);

            for(int tentativa = 1; tentativa <= tentativasMax; tentativa++)
            {
                Console.WriteLine($"Tentativa {tentativa} de {tentativasMax}.");

                Console.WriteLine($"Digite um número entre 1 e {numMax}:");
                int input = Convert.ToInt32(Console.ReadLine());
                
                if (input < 1 || input > numMax)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($"Valor inválido! O número deve ser entre 1 e {numMax}.");
                    Console.WriteLine("------------------------------");
                    break;
                }   
                
                bool numRepetido = false;

                for(int i=0; i< numDigitados.Length; i++)
                {
                    if (numDigitados[i] == input)
                    {
                        numRepetido = true;
                        break;
                    }
                }
                if(numRepetido == true)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Você já digitou esse número, tente novamente.");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Digite ENTER para continuar...");
                    Console.ReadLine();

                    tentativa--;
                    continue;

                }
                if(countNumDigitados < numDigitados.Length)
                {
                    numDigitados[countNumDigitados] = input;
                    countNumDigitados++;
                }

                if (input == numeroAleatorio)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Parabéns! Você acertou o número!");
                    Console.WriteLine("------------------------------");
                    break;
                }
                else if (input > numeroAleatorio)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("O número digitado é maior do que o número aleatório.");
                    Console.WriteLine("------------------------------");
                }
                else
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("O número digitado é menor do que o número aleatório.");
                    Console.WriteLine("------------------------------");
                }

                int difNum = Math.Abs(numeroAleatorio-input);
                if(difNum >= 10)
                {
                    starPoint -= 100;

                }
                else if(difNum >= 5)
                {
                    starPoint -= 50;
                }
                else
                {
                    starPoint -= 20;
                }

                if(tentativa == tentativasMax)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($"Fim de jogo! O número aleatório era {numeroAleatorio}.");
                    Console.WriteLine($"Sua pontuação final é: {starPoint}");
                    Console.WriteLine("------------------------------");
                }


            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Deseja jogar novamente? (s/n)");
            Console.WriteLine("------------------------------");

            string? continuar = Console.ReadLine();
            if (continuar != "s" && continuar != "S")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Obrigado por jogar! Até a próxima!");
                Console.WriteLine("------------------------------");
                break;
            }
        }
    }   
}
    






    
