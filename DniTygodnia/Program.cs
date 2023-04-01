using System;
using System.Diagnostics;

namespace DniTygodnia
{
    internal class Program
    {
        //Napisz program, który wczytuje liczbę od 1 do 7 i wyświetla nazwę dnia tygodnia (1 to poniedziałek). Zastosuj instrukcję switch
        static void Main(string[] args)
        {
            Console.Write("-->");
            int liczba = int.Parse(Console.ReadLine());
            switch (liczba)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie znam:(");
                    break;
            }
            Console.ReadKey();
        }
    }
}