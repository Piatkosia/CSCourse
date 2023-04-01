namespace OddOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Liczba 1: ");
            int liczba = int.Parse(Console.ReadLine());
            string przedrostek =  (liczba % 2 == 0) ? "" : "nie";
            Console.WriteLine($"Liczba {liczba} jest {przedrostek}parzysta");
            Console.ReadKey();
        }
    }
}