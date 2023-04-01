namespace CSCourse
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Liczba 1: ");
            int pierwsza = int.Parse(Console.ReadLine());
            Console.Write("Liczba2: ");
            int druga = int.Parse(Console.ReadLine());
            if (druga == 0)
            {
                Console.WriteLine("Nie ma takich, dzielenie mi nie wyjdzie.");
                return;
            }
            Dictionary<char, Func<int, int, long>> functions = new Dictionary<char, Func<int, int, long>>
            {
                { '+', Sum },
                { '-', Sub },
                { '*', Mul },
                { '/', Div },
                { '%', Rest },
            };
            Random r = new Random();
            foreach (var function in functions)
            {
                Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
                Print(function.Key, pierwsza, druga, function.Value(pierwsza, druga));
            }

            Console.ReadKey();
        }

        public static long Sum(int x, int y)
        {
            return x + y;
        }

        public static long Sub(int x, int y)
        {
            return x + y;
        }

        public static long Mul(int x, int y)
        {
            return x * y;
        }

        public static long Div(int x, int y)
        {
            return x / y;
        }

        public static long Rest(int x, int y)
        {
            return x % y;
        }

        public static void Print(char symbol, int pierwsza, int druga, long wynik)
        {
            Console.WriteLine($"{pierwsza} {symbol} {druga} = {wynik}");
        }
    }
    
}