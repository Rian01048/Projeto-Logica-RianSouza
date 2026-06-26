using System;

public class Program
{
    public static void Main (string[] args)
    {
        Console.WriteLine("===== Tabuada =====");
        Console.WriteLine("1 - Multiplicação\n" +
            "2 - Divisão\n" +
            "3 - Soma\n" +
            "4 - Subtração\n" +
            "Clique algo para finalizar o sistema");
        Console.Write("Escolha: ");
        byte escolha = byte.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Multiplicar");
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());
                for (int count = 0; count < 10; count++)
                {
                    Console.WriteLine($"{count+1} x {numero} = {(count+1) * numero}");
                }
                break;

            case 2:
                Console.Clear();
                Console.WriteLine("Divisão");
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());
                for (int count = 0; count < 10; count++)
                {
                    Console.WriteLine($"{count + 1} / {numero} = {(count+1) / numero}");
                }
                break;

            case 3:

                Console.Clear();
                Console.WriteLine("Soma");
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());
                for (int count = 0; count < 10; count++)
                {
                    Console.WriteLine($"{count + 1} + {numero} = {(count + 1) + numero}");
                }
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Subtrair");
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());
                for (int count = 0; count < 10; count++)
                {
                    Console.WriteLine($"{count + 1} - {numero} = {(count + 1) - numero}");
                }
                break;
            default:
                Console.WriteLine("Finalizando o programa");
                break;
        }


    }
}