namespace Tabelka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] tab = new int[100];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = r.Next();
                Console.WriteLine($"Tab[{i}] = {tab[i]}");
            }

            Console.ReadKey();
        }
    }
}