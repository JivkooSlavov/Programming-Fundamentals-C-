namespace _3.SchooLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shelftWithBooks = Console.ReadLine().Split("&", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] books = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                string function = books[0];
                if (function == "Add Book")
                {
                    string bookName = books[1];
                    if (!shelftWithBooks.Contains(bookName))
                    {
                        shelftWithBooks.Insert(0, bookName);
                    }
                }
                else if (function== "Take Book")
                {
                    string bookName = books[1];
                    if (shelftWithBooks.Contains(bookName))
                    {
                        shelftWithBooks.Remove(bookName);

                    }
                }
                else if (function == "Swap Books")
                {
                    string bookNameOne = books[1];
                    string bookNameTwo = books[2];

                    if (shelftWithBooks.Contains(bookNameOne) && shelftWithBooks.Contains(bookNameTwo))
                    {
                        int indexOfBookOne = shelftWithBooks.IndexOf(bookNameOne); //1
                        int indexOfBookTwo = shelftWithBooks.IndexOf(bookNameTwo); ///2
                        (shelftWithBooks[indexOfBookOne], shelftWithBooks[indexOfBookTwo]) = (shelftWithBooks[indexOfBookTwo], shelftWithBooks[indexOfBookOne]);
                    }
                }
                else if (function == "Insert Book")
                {
                    string bookName = books[1];
                    if (!shelftWithBooks.Contains(bookName))
                    {
                        shelftWithBooks.Add(bookName);
                    }
                }
                else if (function == "Check Book")
                {
                    int indexOfBook = int.Parse(books[1]);
                    if (indexOfBook>=0 && indexOfBook<shelftWithBooks.Count)
                    {
                        Console.WriteLine(shelftWithBooks[indexOfBook]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", shelftWithBooks));
        }
    }
}