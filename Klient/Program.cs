namespace Klient
{
    internal class Program
    {
        //. Napisz program, który wczyta dane klienta (imię, nazwisko oraz wiek), a następnie wyświetli wczytane dane.

        static void Main(string[] args)
        {
            Console.Write("Imię: ");
            string imie = Console.ReadLine();
            Console.Write("Nazwisko: ");
            string nazwisko = Console.ReadLine();
            Console.Write("Wiek: ");
            uint wiek = uint.Parse(Console.ReadLine());
            Console.WriteLine($"{imie} {nazwisko} ma {wiek} lat(a)");
        }
    }
}