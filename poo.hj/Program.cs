using System;

class Program
{
    static void Main()
    {
        // Declaração e atribuição de variáveis
        int numeroInteiro = 45;
        float numeroDecimal = 3.14f;
        string texto = "Olá, mundo!";
        bool valorLogico = true;

        // Impressão dos valores no console
        Console.WriteLine("Valor da variável int: " + numeroInteiro);
        Console.WriteLine("Valor da variável float: " + numeroDecimal);
        Console.WriteLine("Valor da variável string: " + texto);
        Console.WriteLine("Valor da variável bool: " + valorLogico);

        // Mantém a janela do console aberta até que o usuário pressione uma tecla
        Console.ReadKey();
    }
}
