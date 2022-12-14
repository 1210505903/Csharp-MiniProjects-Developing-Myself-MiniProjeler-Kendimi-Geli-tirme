using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            //manager.add(new )
        }
    }
    interface IPerson//somut nesene
    {
        //en büyük kullanım amacı temel nesene oluşturup diğer tüm neseleeri7
        int Id { get; set; }
        String FirstName { get; set; }
        String LastName { get; set; }
    }
    class Customer:IPerson//soyut nesene
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public String Adress { get; set; }

        int IPerson.Id
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        string IPerson.FirstName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        string IPerson.LastName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
    class Student:IPerson//birleşimi
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public String Depertman { get; set; }

        string IPerson.FirstName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        string IPerson.LastName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }

    class PersonManager
    {
        public void add(Customer customer)
        {
            //Console.WriteLine(customer.);
        }
    }
}
