using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //Collections();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["book"]);
            Console.ReadLine();
        }

        private static void Collections()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, firstName = "Ömer" });
            customers.Add(new Customer { Id = 2, firstName = "Serfice" });




            var customer1 = new Customer
            {
                Id = 3,
                firstName = "Omer"
            };
            customers.Add(customer1);
            customers.AddRange(new Customer[2]

                {
                    new Customer{Id=4,firstName="Ali" },
                    new Customer{Id=5, firstName= "Ayşe"}
                });

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.firstName);
            }
            var count = customers.Count;
            Console.WriteLine("Count: {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("İstanbul");
            foreach (var city in cities)
            {
                Console.WriteLine(city);


            }


        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string firstName { get; set; }
    }
}
