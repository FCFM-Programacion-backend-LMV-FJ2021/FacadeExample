using FacadeExample.Facade;
using System;
using System.Collections.Generic;

namespace FacadeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hagamos un recibo de compra!");

            var products = new List<ProductsModel>();
            products.Add(new ProductsModel() { Price = 90, Title = "Fund p celular" });
            products.Add(new ProductsModel() { Price = 10, Title = "Coca cola lata" });

            Console.WriteLine(new InvoiceFacade().PrintReceipt(products));
            
            Console.ReadKey();

        }
    }
}
