using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        public List<Product> bags;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bags =new List<Product>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public void BayProduct(Product product)
        {
            if (this.money >= product.Cost)
            {
                this.money -= product.Cost;
                Console.WriteLine($"{this.name} bought {product.name}");
                this.bags.Add(product);
            }
            else
            {
                Console.WriteLine(this.name+ " can't afford "+product.name);
            }
        }
    }

    public class Product
    {
        public string name;
        public decimal cost;
       
        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.cost = value;
            }
        }
    }
    class ShoppingSpree
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            string[] inputPersons = Console.ReadLine().Split(new[] {'=', ';'});
            string[] inputProducts = Console.ReadLine().Split(new[] { '=', ';' });
            try
            {
                for (int i = 0; i < inputPersons.Length - 1; i += 2)
                {
                    Person p = new Person(inputPersons[i], decimal.Parse(inputPersons[i + 1]));
                    persons.Add(p);
                }
                for (int i = 0; i < inputProducts.Length - 1; i += 2)
                {
                    Product product = new Product(inputProducts[i], decimal.Parse(inputProducts[i + 1]));
                    products.Add(product);
                }
                string[] commond = Console.ReadLine().Split();
                while (commond[0] != "END")
                {
                    foreach (var p in persons)
                    {
                        if (p.Name == commond[0])
                        {
                            foreach (var item in products)
                            {
                                if (item.name == commond[1])
                                {
                                    p.BayProduct(item);
                                }
                            }
                        }
                    }
                    commond = Console.ReadLine().Split();
                }
               
                foreach (var p in persons)
                {
                    if (p.bags.Count > 0)
                    {
                        var productsNames= string.Join(", ", p.bags.Select(z => z.Name));
                        Console.WriteLine(p.Name + " - " + productsNames);
                        
                    }
                    else
                    {
                        Console.WriteLine($"{p.Name} - Nothing bought");
                    }
                 }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
