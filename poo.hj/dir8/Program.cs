namespace dir8;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        int num3 = int.Parse(Console.ReadLine());

        int maior = num1;

        if (num2 > maior)
        {
            maior = num2;
        }
        if (num3 > maior)
        {
            maior = num3;
        }

        int menor = num1;

        if (num2 < menor)
        {
            menor = num2;
        }
        if (num3 < menor)
        {
            menor = num3;
        }

        Console.WriteLine($"O maior número é: {maior}");
        Console.WriteLine($"O menor número é: {menor}");
    }
}
