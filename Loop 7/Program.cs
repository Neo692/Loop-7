using System;

class Program
{
    static void Main()
    {
        Console.Write("Skriv in ett positivt tal: ");
        int nummer = int.Parse(Console.ReadLine());

        while (nummer >= 0)
        {
            Console.Write("Skriv in ett positivt tal: ");
            nummer = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Du skrev in ett negativt tal. Programmet avslutas.");
    }
}
