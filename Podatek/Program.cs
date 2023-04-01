namespace Podatek
{
    internal class Program
    {
        //Napisz program, który od podanej ceny netto i stawki VAT oblicza kwotę VAT i cenę brutto.
        //    Np.cena netto 100 zł, stawka 22% daje kwotę VAT 22 zł i cenę brutto 122 zł.
        //    Wyświetlaj kwoty z dwoma miejscami po przecinku, wyświetlając dodawaj symbol waluty i znak %
        //(procent).


        static void Main(string[] args)
        {
            Console.Write("Netto: ");
            int netto = int.Parse(Console.ReadLine());
            Console.Write("Podatek (w %): ");
            int podatek = int.Parse(Console.ReadLine());
            double kwotaPodatku = (double)podatek / 100 * netto;
            Console.WriteLine($"Kwota podatku: {kwotaPodatku:f2} zł");
            Console.WriteLine($"Kwota brutto: {(netto+ kwotaPodatku):f2} zł");
        }
    }
}