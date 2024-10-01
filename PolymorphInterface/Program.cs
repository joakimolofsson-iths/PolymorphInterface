using System.Security.Cryptography.X509Certificates;

namespace PolymorphInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrivatKund newPrivatKund = new PrivatKund(123456789, 1000m, "Privat");
            newPrivatKund.SkickaArsrapport();
        }

        class Kund
        {
            protected int Kortnummer { get; set; }
            protected decimal Saldo { get; set; }
            protected string KundTyp { get; set; }

            public Kund(int kortnummer, decimal saldo, string kundTyp)
            {
                Kortnummer = kortnummer;
                Saldo = saldo;
                KundTyp = kundTyp;
            }

            public void SkickaArsrapport()
            {
                Console.WriteLine(
                    $"Skickar årsrapport för: {KundTyp}\n" +
                    $"Kontonummer: {Kortnummer}\n" +
                    $"Saldo: {Saldo} SEK"
                );
            }
        }

        class PrivatKund : Kund
        {
            public PrivatKund(int kortnummer, decimal saldo, string kundTyp)
                : base(kortnummer, saldo, kundTyp)
            {

            }
        }

        class ForetagsKund : Kund
        {
            public ForetagsKund(int kortnummer, decimal saldo, string kundTyp)
                : base(kortnummer, saldo, kundTyp)
            {

            }
        }
    }
}
