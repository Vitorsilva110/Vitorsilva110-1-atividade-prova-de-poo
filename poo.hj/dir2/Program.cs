namespace dir2;

class Program
{
    static void Main()
    {
        
        Console.Write("Digite o primeiro número inteiro: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro: ");
        int num2 = int.Parse(Console.ReadLine());

        
        int soma = num1 + num2;
        int subtracao = num1 - num2;
        int multiplicacao = num1 * num2;

        
        string divisao;
        if (num2 != 0)
        {
            divisao = (num1 / (double)num2).ToString();
        }
        else
        {
            divisao = "Indefinida (divisão por zero)";
        }

        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        Console.WriteLine($"Divisão: {divisao}");
    }
}
