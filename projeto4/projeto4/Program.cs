using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===== Números pares e impares");
        Console.Write("Digite a quantidade de número que vc quer digitar: ");
        int registro = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");


        for (int count = 0; count < registro; count++)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Número Par");
                Console.WriteLine("\n");

            }
            else
            {
        
                Console.WriteLine("Número impar");
                Console.WriteLine("\n");

            }
        }
    }
}