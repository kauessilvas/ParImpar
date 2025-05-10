int number;

Console.WriteLine("====== Impar ou Par ======");
while (true)
{
    Console.Write("Digite um número: ");
    string input = Console.ReadLine()!;

    if (int.TryParse(input, out number))
    {
        break; 
    }
    else
    {
        Console.WriteLine("Entrada inválida. Tente novamente.");
    }
}

if (number % 2 == 0)
{
    Console.WriteLine("O número é par.");
}
else
{
    Console.WriteLine("O número é ímpar.");
}