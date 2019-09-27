using System;
namespace metoder 2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv tal ett: ");
            double nummer1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Skriv tal två: ");
            double nummer2 = Convert.ToDouble(Console.ReadLine());
            ChangePlace(ref nummer1, ref nummer2);
            Console.WriteLine("Nu bytte talen plats!");
            Console.WriteLine($"Tal ett är nu istället {nummer1} och tal två är nu istället {nummer2}");
        }
        static void ChangePlace(ref double nummer3, ref double nummer4)
        {
            double tempNumber = nummer3;
            nummer3 = nummer4;
            nummer4 = tempNumber;
        }
    }
}