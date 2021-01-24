using System;

namespace DamaUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
        }
        class CustomerManager
        {
            public void Add()
            {
                Console.WriteLine("Customer Added");
            }
            public void Update()
            {
                Console.WriteLine("Customer Update");
            }

        }
        class ProductManager
        {
            public void Add(string name)
            {
                Console.WriteLine("Product Added");
            }
            public void Update()
            {
                Console.WriteLine("Product Update");
            }
        }
    }
}
