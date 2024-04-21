using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Lekce1_BreakOut2
{
    public class Clovek
    {
       public string Jmeno;
        public int TelCislo;
        public Clovek(string jmeno, int telCislo)
        {
            Jmeno = jmeno;
            TelCislo = telCislo;
            while (telCislo.ToString().Length < 9)
            {
                Console.WriteLine($"{telCislo} je neplatné telefonní číslo, musí obsahovat alespoň 9 číslic");
                telCislo = int.Parse(Console.ReadLine());
            }
        }
        public void VypisJmenoACislo()
        {
            Console.WriteLine();
            Console.WriteLine($"Jméno: {Jmeno}, Tel. číslo: {TelCislo}");
            return;
        }
    }
    public class ClovekVyjimky
    {
        public static void Main()
        {
            Console.WriteLine("Program na vytvareni telefonniho seznamu");
            Console.WriteLine("========================================");
            Console.Write("Zadejte jmeno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadejte telefonni cislo: ");
            int cislo = 0;
            try 
            {
                cislo = int.Parse(Console.ReadLine());
            }
            catch (FormatException vyjimka)
            {
                Console.WriteLine(vyjimka.Message);
                Console.WriteLine("Nezadal jsi správně telefonní číslo");
                return;
            }
            catch (OverflowException vyjimka)
            {
                Console.WriteLine(vyjimka.Message);
                Console.WriteLine("Zadané číslo bylo moc velké");
                return;
            }
            Clovek prvniClovek;
            try
            {
                prvniClovek = new Clovek(jmeno, cislo);
                prvniClovek.VypisJmenoACislo();
            }
            catch (Exception vyjimka)
            {
                Console.WriteLine(vyjimka.Message);
            }
            Console.WriteLine("=== Program končí ===");
        }
    }
}
