namespace dir11;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro para calcular o fatorial: ");
        int numero = int.Parse(Console.ReadLine());

        long fatorial = CalcularFatorial(numero);

        if (numero < 0)
        {
            Console.WriteLine("O fatorial não está definido para números negativos.");
        }
        else
        {
            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        }
    }

    static long CalcularFatorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else if (n < 0)
        {
            throw new ArgumentException("O fatorial não está definido para números negativos.");
        }
        
        else
        {
            return n * CalcularFatorial(n - 1);
        }
    }
}

