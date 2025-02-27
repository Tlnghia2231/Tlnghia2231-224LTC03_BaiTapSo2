namespace Baitap4
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }

        public Book(string title_231, string author_231, string language_231)
        {
            Title = title_231;
            Author = author_231;
            Language = language_231;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Ten sach: " + Title + ", tac gia: " + Author + ", ngon ngu: " + Language);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books_231 = new Book[]
            {
                new Book("The Lord of the Rings", "J. R. R. Tolkien", "English"),
                new Book("War and Peace", "Leo Tolstoy", "Russian"),
                new Book("The Catcher in the Rye", "J. D. Salinger", "English"),
                new Book("One Hundred Years of Solitude", "Gabriel García Márquez", "Spanish"),
                new Book("Crime and Punishment", "Fyodor Dostoevsky", "Russian")
            };
            Console.WriteLine("Danh sach cac quyen sach noi tieng tren the gioi:");
            foreach (Book book in books_231)
            {
                book.ShowInfo();
            }
        }
    }
}
