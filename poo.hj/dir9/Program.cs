namespace dir9;

class Program
{
    static void Main()
    {
        int soma = 0;
        int numero;

        Console.Write("Digite um número (ou 0 para terminar): \n");
        numero = 1;

        do
        {
            numero = int.Parse(Console.ReadLine());
            soma += numero;
        }while (numero != 0);
    
        Console.WriteLine($"A soma de todos os números digitados é: {soma}");
    }
}
