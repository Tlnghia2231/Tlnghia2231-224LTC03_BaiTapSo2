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

        public Dog(string name_231, DogBreed breed_231, string furColor_231 = "Trang")
        {
            Name = name_231;
            Breed = breed_231;
            FurColor = furColor_231;
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
            Dog dog1_231 = new Dog("Max", DogBreed.Labrador, "Vang");
            Dog dog2_231 = new Dog("Bella", DogBreed.Husky);
            Dog dog3_231 = new Dog("Charlie", DogBreed.Poodle, "Nau");
            Dog dog4_231 = new Dog("Rocky", DogBreed.Bulldog, "Dom trang");
            Dog dog5_231 = new Dog("Daisy", DogBreed.Beagle);
            Dog dog6_231 = new Dog("Lucky", DogBreed.GoldenRetriever, "Vang kem");
            Dog dog7_231 = new Dog("Duke", DogBreed.GermanShepherd);
            Dog dog8_231 = new Dog("Teddy", DogBreed.Poodle, "Trang");
            Dog dog9_231 = new Dog("Luna", DogBreed.Husky, "Xam");
            Dog dog10_231 = new Dog("Bruno", DogBreed.Labrador, "Den");

            List<Dog> dogs_231 = new List<Dog> { dog1_231, dog2_231, dog3_231, dog4_231, dog5_231, dog6_231, dog7_231, dog8_231, dog9_231, dog10_231 };
            Console.WriteLine("\nThong tin cac chu cho:");
            foreach (Dog dog in dogs_231)
            {
                dog.ShowInfo();
            }
        }
    }
}
