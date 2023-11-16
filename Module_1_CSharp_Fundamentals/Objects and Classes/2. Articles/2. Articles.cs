namespace _2._Articles
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
        public string Content { get; set;}
        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main()
        {
            string[] articleStr = Console.ReadLine()
                .Split(", ")
                .ToArray();
            
            Article article = new Article(articleStr[0], articleStr[1], articleStr[2]);

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                switch (command[0])
                {
                    case "Edit":
                        string newContent = command[1];
                        article.Edit(newContent);
                        break;
                    case "ChangeAuthor":
                        string newAuthor = command[1];
                        article.ChangeAuthor(newAuthor);
                        break;
                    case "Rename":
                        string newTitle = command[1];
                        article.Rename(newTitle);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }
}