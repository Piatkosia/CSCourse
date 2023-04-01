namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            var pierwsza = r.Next(1, 10);
            var druga = r.Next(1, 10);
            var wynik = pierwsza + druga;
            int raz = 1;
            int wynikUzytkownika = 0;
            wynikUzytkownika = PobierzWynik(pierwsza, druga);
            while (wynikUzytkownika != wynik)
            {
                Console.WriteLine("Zła odpowiedź!");
                raz++;
                wynikUzytkownika = PobierzWynik(pierwsza, druga);
            }

            Console.WriteLine($"Brawo! Gratulacje. To jest {wynik}! Zgadłeś za {raz} razem!");
        }

        private static int PobierzWynik(int pierwsza, int druga)
        {
            Console.Write($"{pierwsza} + {druga} = ");
            return int.Parse(Console.ReadLine());
        }
    }
}