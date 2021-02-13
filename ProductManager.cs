using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work4
{
    class ProductManager
    {
        public void Add(Product product)
        {
           
            Console.WriteLine(product.ProductName+" "+"eklendi." +  " " +"Id"+ " "+product.Id +
                                                   " "+ "UnitPrice "+" " + product.UnitPrice); 
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+ " " + "güncellendi." + " " + "Id" + " " + product.Id +
                                                   " " + "UnitPrice " + " " + product.UnitPrice); 
        }
        
       


    }
}
