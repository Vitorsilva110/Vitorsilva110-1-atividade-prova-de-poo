namespace dir13;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de nomes que deseja inserir: ");
        int quantidade = int.Parse(Console.ReadLine());

        string[] nomes = new string[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Digite o nome {i + 1}: ");
            nomes[i] = Console.ReadLine();
        }

        BubbleSort(nomes);

        Console.WriteLine("Lista de nomes em ordem alfabética:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }

    static void BubbleSort(string[] array)
    {
        int n = array.Length;
        bool trocou;
        do
        {
            trocou = false;
            for (int i = 0; i < n - 1; i++)
            {
                if (string.Compare(array[i], array[i + 1]) > 0)
                {
                    string temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    trocou = true;
                }
            }
        }
        while (trocou);
    }
}
