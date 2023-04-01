namespace Petla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Tab[{i}] = ");
                tab[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Średnia = {tab.Average()}"); // System.Linq
        }
    }
}