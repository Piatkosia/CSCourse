namespace Prostokat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#======A=====#");
            Console.WriteLine("|            |");
            Console.WriteLine("B            B");
            Console.WriteLine("|            |");
            Console.WriteLine("#======A=====#");
            Console.Write("A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine($"P = {A * B}");
            Console.WriteLine($"O = {2*A + 2*B}");
        }
    }
}