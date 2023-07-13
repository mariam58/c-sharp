namespace c_sharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<BookModel> books = new List<BookModel>();
            bool IsFinished = false;
            while (!IsFinished)
            {
                Console.WriteLine("provide book title");
                string bookTitle = Console.ReadLine();

                Console.WriteLine("provide book author");
                string bookAuthor = Console.ReadLine();

                Console.WriteLine("provide book genre");
                string bookGenre = Console.ReadLine();

                BookModel book = new BookModel(bookTitle, bookAuthor, bookGenre);
                books.Add(book);

                Console.WriteLine("do you whant to continue?");

                string answer = Console.ReadLine();
                if (answer == "No")
                {
                    IsFinished = true;
                    foreach (var item in books)
                    {
                        Console.WriteLine(item.Title);
                        Console.WriteLine(item.Author);
                        Console.WriteLine(item.Genre);
                    }
                }

            }


        }

    }

    public class BookModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        public BookModel(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }
    }
}