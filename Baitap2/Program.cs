namespace ConsoleApp1
{
    enum DogBreed
    {
        Labrador, Husky, Poodle, Bulldog, Beagle, GoldenRetriever, GermanShepherd
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Danh sach cac giong cho hien co trong quay");
            foreach (DogBreed tmp_231 in Enum.GetValues(typeof(DogBreed)))
            {
                Console.WriteLine(((int)tmp_231 + 1) + "." + tmp_231);
            }
            Console.Write("\nNhap so ma giong cho ban quan tam : ");
            if (int.TryParse(Console.ReadLine(), out int userChoice_231))
            {
                if (Enum.IsDefined(typeof(DogBreed), userChoice_231 - 1))
                {
                    Console.WriteLine("Ban dang tim hieu ve : " + (DogBreed)(userChoice_231 - 1));
                }
                else
                {
                    Console.WriteLine("Khong co giong cho nay!");
                }
            }
            else
            {
                Console.WriteLine("Vui long nhap so!");
            }
        }
    }
}
