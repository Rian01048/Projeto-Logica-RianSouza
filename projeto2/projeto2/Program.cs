using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===== Verificação de idade =====");
        Console.WriteLine("===== Verifique 5 idades =====");
        Console.WriteLine("\n");
        for (int count = 0; count < 5; count++)
        {
            Console.Write($"Digite a {count + 1}° idade: ");
            byte idade = byte.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine($"\nIdade: {idade}");
                Console.WriteLine("===== Maior de idade =====\n");
            }
            else
            {
                Console.WriteLine($"\nIdade: {idade}");
                Console.WriteLine("===== Menor de Idade =====\n");
            }
        }
    }
}