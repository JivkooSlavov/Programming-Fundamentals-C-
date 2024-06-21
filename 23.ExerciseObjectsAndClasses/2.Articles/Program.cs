namespace _02.Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Authors = author;

        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Authors { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthors(string newAuthor)
        {
            Authors = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Authors = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Authors}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleArray = Console.ReadLine().Split(", ").ToArray();

            Article article= new Article(articleArray[0], articleArray[1], articleArray[2]);

            int commandCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                if (command[0]=="Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthors(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    article.Rename(command[1]);
                }
            }
            Console.WriteLine(article);
        }
    }
}