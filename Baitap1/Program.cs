namespace Baitap1
{
    internal class Program
    {
        class Dog
        {
            public string giongCho { get; set; }
            public string mauLong { get; set; }

            public Dog(string giongCho_231, string mauLong_231)
            {
                this.giongCho = giongCho_231;
                this.mauLong = mauLong_231;
            }

            public static Dog CreateDog(string giongCho_231, string mauLong_231 = "Trang")
            {
                return new Dog(giongCho_231, mauLong_231);
            }

            public void ShowInfo()
            {
                Console.WriteLine("Giong cho: " + giongCho + ", mau long: " + mauLong);
            }
        }
        static void Main(string[] args)
        {
            Dog dog1_231 = Dog.CreateDog("Husky", "den");
            dog1_231.ShowInfo();

            Dog dog2_231 = Dog.CreateDog("Poodle");
            dog2_231.ShowInfo();
        }
    }
}
