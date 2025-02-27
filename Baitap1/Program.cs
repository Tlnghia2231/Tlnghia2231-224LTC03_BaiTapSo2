namespace Baitap1
{
    internal class Program
    {
        class Dog
        {
            public string giongCho { get; set; }
            public string mauLong { get; set; }

            public Dog(string giongCho, string mauLong)
            {
                this.giongCho = giongCho;
                this.mauLong = mauLong;
            }

            public static Dog CreateDog(string giongCho, string mauLong = "trang")
            {
                return new Dog(giongCho, mauLong);
            }

            public void ShowInfo()
            {
                Console.WriteLine("Giong cho: " + giongCho + ", mau long: " + mauLong);
            }
        }
        static void Main(string[] args)
        {
            Dog dog1 = Dog.CreateDog("Husky", "den");
            dog1.ShowInfo();

            Dog dog2 = Dog.CreateDog("Poodle");
            dog2.ShowInfo();
        }
    }
}
