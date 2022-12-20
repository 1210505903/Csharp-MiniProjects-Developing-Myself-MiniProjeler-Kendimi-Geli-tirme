 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.list();

            Product product = new Product { Id = 1, Name = "Leptop" };
            Product prodtct2 = new Product(2, "Computer");

            //EmployManager emplymoanger = new EmployManager(new DatabaseLogger);       
           // emplymoanger.add();


            Console.ReadLine();
        }
    }
    class CustomerManager{
        private int _count=15;

        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()
        {

        }
        public void list()
        {
            Console.WriteLine("Listed! {0} listed ",_count);
        }
        public void add()
        {
            Console.WriteLine("Added!");
        }
    } 
    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id,String name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    interface ILoger
    {
        void log();
    }
    class DatabaseLogger:ILoger
    {
        public void log()
        {
            Console.WriteLine("Logged to database"); 
        }
    }
    class FilerLogger : ILoger
    {
        public void log()
        {
            Console.WriteLine("Logged to File");
        }
    }
    class EmployManager
    {
        private ILoger _logger;
        public EmployManager(ILoger logger)
        {
            _logger = logger;
        }
        public ILoger Logger { get; set; }
        public void add()
        {
            _logger.log();
            Console.WriteLine("Added");
        }
    }
    class BaseClass
    {
        private string _entitiy;
        public BaseClass(string entity)
        {
            _entitiy = entity;
        }
        public void Mesaager()
        {
            Console.WriteLine("{0} message");
        }
    }
    class PerspnManager: BaseClass
    {
        public PerspnManager(string entitiy) : base(entitiy)
        {
            
        }
        public void add()
        {
            Console.WriteLine("Add");
            Mesaager();
        }
    }
}


 