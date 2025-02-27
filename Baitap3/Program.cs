using System.Collections;

namespace Baitap3
{
    enum DogBreed
    {
        Labrador, Husky, Poodle, Bulldog, Beagle, GoldenRetriever, GermanShepherd
    }

    class Dog
    {
        public string Name { get; set; }
        public DogBreed Breed { get; set; }
        public string FurColor { get; set; }

        public Dog(string name, DogBreed breed, string furColor = "Trang")
        {
            Name = name;
            Breed = breed;
            FurColor = furColor;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Ten cho: " + Name + ", giong cho : " + Breed + ", mau long: " + FurColor);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Max", DogBreed.Labrador, "Vang");
            Dog dog2 = new Dog("Bella", DogBreed.Husky);
            Dog dog3 = new Dog("Charlie", DogBreed.Poodle, "Nau");
            Dog dog4 = new Dog("Rocky", DogBreed.Bulldog, "Dom trang");
            Dog dog5 = new Dog("Daisy", DogBreed.Beagle);
            Dog dog6 = new Dog("Lucky", DogBreed.GoldenRetriever, "Vang kem");
            Dog dog7 = new Dog("Duke", DogBreed.GermanShepherd);
            Dog dog8 = new Dog("Teddy", DogBreed.Poodle, "Trang");
            Dog dog9 = new Dog("Luna", DogBreed.Husky, "Xam");
            Dog dog10 = new Dog("Bruno", DogBreed.Labrador, "Den");

            List<Dog> dogs = new List<Dog> { dog1, dog2, dog3, dog4, dog5, dog6, dog7, dog8, dog9, dog10 };
            Console.WriteLine("\nThong tin cac chu cho:");
            foreach (Dog dog in dogs)
            {
                dog.ShowInfo();
            }
        }
    }
}
