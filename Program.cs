using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work4
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;


            Product product2 = new Product();
            product2.Id = 2;
            product2.CategoryId = 3;
            product2.ProductName = "koltuk";
            product2.UnitPrice = 600;
            product2.UnitInStock = 4;

            Product product3 = new Product { Id = 3, ProductName = "kalem" ,CategoryId = 4, UnitPrice = 35, UnitInStock = 20 };

            Console.WriteLine("-------------------------");

            ProductManager productManager = new ProductManager(); // ekle, sil, listele gibi şeyleri yapar.
            productManager.Add(product1);
            productManager.Add(product2);
            Console.WriteLine("---------");
            productManager.Update(product2);



            Console.ReadKey();
        }
    }
}
