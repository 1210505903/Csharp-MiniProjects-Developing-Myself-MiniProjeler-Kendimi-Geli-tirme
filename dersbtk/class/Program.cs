using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Program
    {
        static void Main(string[] args)
        {
           CustomerManager customermanger = new CustomerManager();
            customermanger.add();
            customermanger.update();

           
            Customer customer = new Customer();
            customer.City = "İstanbul";
            customer.Id =1;
            customer.FirstName = "Yusuf";
            customer.LastName = "Güner";

            Customer customer2 = new Customer {
                Id = 2,City="Bilecik",FirstName="Batuhan",LastName="Salkım"

            };
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }
    class CustomerManager{
        public void add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }
        public void update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    
    }
    class Customer
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String City { get; set; }
       
    }   


}
