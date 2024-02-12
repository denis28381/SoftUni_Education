namespace _3._Articles_2._0
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Author = author;
            Content = content;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main()
        {
            List<Article> articles = new List<Article>();

            int articleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < articleCount; i++)
            {
                string[] articleStr = Console.ReadLine()
                    .Split(", ")
                    .ToArray();

                Article article = new Article(articleStr[0], articleStr[1], articleStr[2]);

                articles.Add(article);
            }

            Console.WriteLine(string.Join("\n", articles));
        }
    }
}