namespace dir6;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
            Console.WriteLine("Você está apto a votar e a dirigir.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
            Console.WriteLine("Você ainda não está apto a votar e a dirigir.");
        }
    }
}
