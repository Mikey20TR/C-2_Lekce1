namespace C_2_Lekce1
{
    public class DovolenaOdjezd
    {
        public static void Main()
        {
            // Zbyvajici dny do dovolene
            // Postupne se uzivatele zeptej na den, mesic a rok odjezdu na dovolenou. Pomoci DateTime a TimeSpan vypocitej pocet
            // zbyvajicich dni do odjezdu na dovolenou a vypis je na konzoli.
            // Pozn.: pro zjednoduseni staci pouzit int.Parse
            Console.WriteLine("Zadej datum tvého odjezdu na dovolenou");
            Console.WriteLine("Zadej den:");
            int den = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej měsíc:");
            int mesic = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej rok:");
            int rok = int.Parse(Console.ReadLine());

            DateTime Ted = DateTime.Today;
            DateTime denOdjezdu = new DateTime(rok, mesic, den);
            TimeSpan pocetDniDoOdjezdu = denOdjezdu - Ted;
            Console.WriteLine($"Do odjezdu zbývá {pocetDniDoOdjezdu.TotalDays} dní, což je {pocetDniDoOdjezdu.TotalHours} hodin");
        }
    }
}
