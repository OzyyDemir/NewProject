using Business.Concrete;
using DataAccess.Concrete.InMemorry;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
