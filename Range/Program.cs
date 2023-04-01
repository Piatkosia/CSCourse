using System.ComponentModel.DataAnnotations;

namespace Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Liczba: ");
            int liczba = int.Parse(Console.ReadLine());
            if (liczba < 10)
            {
                return; //nic do wypisania
            }

            foreach (var number in Enumerable.Range(10, 90).Where(x => x < liczba))
            {
                Console.WriteLine(number);
            }
            
        }
    }
}