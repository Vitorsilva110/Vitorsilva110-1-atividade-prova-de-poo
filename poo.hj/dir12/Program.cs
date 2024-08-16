namespace dir12;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para gerar a sequência de Fibonacci até esse número: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Por favor, digite um número inteiro positivo.");
            return;
        }

        int a = 0;
        int b = 1;

        Console.WriteLine("Sequência de Fibonacci até " + n + ":");

        Console.WriteLine(a);

        while (b <= n)
        {
            Console.WriteLine(b);
            int proximo = a + b;
            a = b;
            b = proximo;
        }
    }
}
