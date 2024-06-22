namespace _3.Articles
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Authors}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();


            int commandCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandCount; i++)
            {
                string[] articleArray = Console.ReadLine().Split(", ").ToArray();
                Article article = new Article(articleArray[0], articleArray[1], articleArray[2]);
                articles.Add(article);
            }
            foreach (Article article in articles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }
}