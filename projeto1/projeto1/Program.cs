using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Número maior e menor =====");
        while (true)
        {
            Console.WriteLine("===== Menu =====\n");
            Console.WriteLine("1 - Rodar o programa\n" +
                "2 - Finalizar o sistema\n");
            Console.Write("Escolha: ");
            byte escolha = byte.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine($"O {num1} é maior, e o {num2} é o menor");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"O {num2} é maior, e o {num1} é o menor");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
            else if (escolha == 2)
            {
                Console.WriteLine("Finalizando o sistema...");
                Thread.Sleep(3000);
                break;
            }
            else
            {
                Console.WriteLine("Digite de 1 a 2");
                Thread.Sleep(3000);
                Console.Clear();
            }
           

        }
        
    }
}