namespace PolymorphInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.MakeSound();
            myAnimal.AnimalMethod();

            Animal myAnimalCat = new Cat();
            myAnimalCat.MakeSound();
            myAnimalCat.AnimalMethod();

            Cat myCat = new Cat();
            myCat.CatMethod();
        }
    }

    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Sound!");
        }

        public void AnimalMethod()
        {
            Console.WriteLine("Animals Only!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Animal Sound!");
        }

        public void CatMethod()
        {
            Console.WriteLine("Cats Only!");
        }
    }
}
