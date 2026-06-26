using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===== Verificar nota do aluno =====");
        Console.Write("===== Digite as 3 notas do aluno =====\n");
        double[] notas = new double[3];

        for (int count = 0; count < 3; count++)
        {
            Console.Write($"\nDigite a {count+1} nota: ");
            notas[count] = double.Parse( Console.ReadLine());
        }

        double soma = notas[0] + notas[1] + notas[2];
        double media = soma / 3;
        Console.WriteLine($"Média: {media:F2}");
        if (media >= 7)
        {
            Console.WriteLine("Aprovado!!");
        }
        else if (media >= 5 && media <= 6.9)
        {
            Console.WriteLine("Recuperação");
        }
        else
        {
            Console.WriteLine("Reprovado!!");
        }
            
    }
}