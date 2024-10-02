using System.Security.Cryptography.X509Certificates;

namespace PolymorphInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*PrivatKund newPrivatKund = new PrivatKund(123456789, 1000m, "Privat");
            newPrivatKund.SkickaArsrapport();*/

            /*Car myCar = new Car(0);
            myCar.Drive();
            myCar.Refuel(50);
            myCar.Drive();*/

            VisaMobler();
        }

        public static void VisaMobler()
        {
            IMobel[] mobler = { 
                new Stol("Future", "Grå", "Metall"),
                new Sang("Rund", "Vit", "Blandat"),
                new Soffa("Tvåsittsig", "Blommig", "Trä och tyg")
            };
            
            foreach(IMobel mobel in mobler)
            {
                Console.WriteLine($"{mobel.Design} {mobel.Farg} {mobel.Material}");
            }
        }

        interface IMobel
        {
            string Design { get; }
            string Farg { get; }
            string Material { get; }
        }

        class Stol : IMobel
        {
            public string Design { get; private set; }
            public string Farg { get; private set; }
            public string Material { get; private set; }

            public Stol(string design, string farg, string material)
            {
                Design = design;
                Farg = farg;
                Material = material;
            }
        }

        class Sang : IMobel
        {
            public string Design { get; private set; }
            public string Farg { get; private set; }
            public string Material { get; private set; }

            public Sang(string design, string farg, string material)
            {
                Design = design;
                Farg = farg;
                Material = material;
            }
        }

        class Soffa : IMobel
        {
            public string Design { get; private set; }
            public string Farg { get; private set; }
            public string Material { get; private set; }

            public Soffa(string design, string farg, string material)
            {
                Design = design;
                Farg = farg;
                Material = material;
            }
        }

        /*abstract class Animal
        {
            public string Name { get; set; }

            public void SetName(string name)
            {

            }

            public void GetName()
            {

            }

            public abstract void Eat();
        }

        class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("Dog is eating!");
            }
        }*/

        /*interface IVehicle
        {
            void Drive();

            bool Refuel(int gasoline);
        }

        class Car : IVehicle
        {
            private int _gasoline;

            public Car(int gasoline)
            {
                _gasoline = gasoline;
            }

            public void Drive()
            {
                if(_gasoline > 0)
                {
                    Console.WriteLine("Driving!");
                }
                else
                {
                    Console.WriteLine("Car has no fuel!");
                }
            }

            public bool Refuel(int gasoline)
            {
                _gasoline = gasoline;
                return true;
            }
        }*/

        /*class Kund
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
        }*/
    }
}
