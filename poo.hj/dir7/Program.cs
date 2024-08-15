namespace dir7;

class Program
{
    static void Main()
    {
        Console.Write("Digite a primeira nota: ");
        float nota1 = float.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        float nota2 = float.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        float nota3 = float.Parse(Console.ReadLine());

        float media = CalcularMedia(nota1, nota2, nota3);

        Console.WriteLine($"A média das notas é: {media}");
    }

    static float CalcularMedia(float n1, float n2, float n3)
    {
        float media = (n1 + n2 + n3) / 3;
        return media;
    }
}
