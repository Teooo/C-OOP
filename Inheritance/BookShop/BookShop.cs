using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, double price)
            : base(title, author, price)
        {
        }

        public override double Price
        {
            get { return base.Price*1.3; }
            protected set { base.Price = value; }
        }
    }
    public class Book
    {
        private string title;
        private string author;
        private double price;
        
        public Book(string author, string title,  double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                if (value.StartsWith("9"))
                {
                    throw new ArgumentException("Author not valid!");
                }
                this.author = value;
            }
        }

        public virtual double Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Type: ").Append(this.GetType().Name)
                    .Append(Environment.NewLine)
                    .Append("Title: ").Append(this.Title)
                    .Append(Environment.NewLine)
                    .Append("Author: ").Append(this.Author)
                    .Append(Environment.NewLine)
                    .Append("Price: ").Append(this.Price.ToString("f1"))
                    .Append(Environment.NewLine);

            return sb.ToString();
        }

    }
    class BookShop
    {
        static void Main(string[] args)
        {
         
                try
                {
                    string author = Console.ReadLine();
                    string title = Console.ReadLine();
                    double price = double.Parse(Console.ReadLine());

                    Book book = new Book(author, title, price);
                    GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

                    Console.WriteLine(book);
                    Console.WriteLine(goldenEditionBook);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

    }
}
