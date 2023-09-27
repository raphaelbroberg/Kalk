using System;

namespace Kalk2
{
    class Program
    {
        static void Main(string[] args)
        {

            //introducerar användaren till miniräknaren
            Console.WriteLine("Välkommen till enkel matematisk kalkylator!");

            //ber användaren att skriva in tal
            Console.Write("Ange det första talet: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ange det andra talet: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Ber användaren att ange en matematisk operation
            Console.Write("Ange en matematisk operation (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            //deklarerar resultat
            double resultat = 0;

            //använder en switch statement för att utföra en matematisk operation
            switch (operation)
            {
                case '+':
                    resultat = num1 + num2;
                    break;

                case '-':
                    resultat = num1 - num2;
                    break;

                case '*':
                    resultat = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        resultat = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Kan inte dela med noll.");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("Ogiltig operation.");
                    return;
            }

            Console.WriteLine($"Resultatet av {num1} {operation} {num2} är {resultat}");
        }
    }
}
