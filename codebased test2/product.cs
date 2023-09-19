using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class product
    {
        public int productid { get; set; }
        public string productname { get; set; }
        public double price { get; set; }
    }
    class q2
    {
        static void Main()
        {
            List<product> products = new List<product>();
            for (int i=0;i<10;i++)
            {
                Console.WriteLine($"enter details for product {i + 1}:");
                Console.Write("productid:");
                int productid = Convert.ToInt32(Console.ReadLine());
                Console.Write("productname:");
                string productname = (Console.ReadLine());
                Console.Write("price:");
                double price = Convert.ToDouble(Console.ReadLine());

                product.Add(new product
                {
                    productid = productid,
                    productname=productname,
                    price=price
                }) ;


            }
            product = products.OrderBy(p => p.price).ToList();
            Console.WriteLine("\nsorted products based on price:");
            foreach(product product in products)
            {
                Console.WriteLine($"product id :{ product.productid},productname:{product.productname},price:{product.price});
            }
        }
    }
}
