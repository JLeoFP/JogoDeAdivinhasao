
using System.Security.Cryptography;
Console.Clear();

while (true)
{
    Console.WriteLine("------------------------------");
    Console.WriteLine("Jogo de Advinhação!");
    Console.WriteLine("------------------------------");

    RandomNumberGenerator.GetInt32(1, 21);      
    int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

    Console.WriteLine("Digite um número entre 1 e 20: ");
    int input = Convert.ToInt32(Console.ReadLine());
        if (input < 1 || input > 20)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Valor inválido! O número deve ser entre 1 e 20.");
            Console.WriteLine("------------------------------");
            break;
        }   
    Console.WriteLine("O valor digitado foi: " + input);
    Console.WriteLine("O número aleatório é: " + numeroAleatorio);

    if (input == numeroAleatorio)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Parabéns! Você acertou o número!");
        Console.WriteLine("------------------------------");
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