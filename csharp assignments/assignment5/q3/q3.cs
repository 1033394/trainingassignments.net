using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    class q3
    {
        private int salesno;
        private int productno;
        private double price;
        private DateTime dateofsale;
        private int qty;
        private double totalamount;
        public q3(int saleno,int prouctno,double price, DateTime dateofsale, int qty)
        {
            this.salesno = salesno;
            this.productno = productno;
            this.price = price;
            this.qty = qty;
            this.dateofsale = dateofsale;
            this.totalamount = qty * price;
        }
        public void showdata()
        {
            Console.WriteLine("salesno: " + salesno);
            Console.ReadLine();
            Console.WriteLine("productno: " + productno);
            Console.ReadLine();
            Console.WriteLine("price: " + price);
            Console.ReadLine();
            Console.WriteLine("date of sale: " + dateofsale);
            Console.ReadLine();
            Console.WriteLine("qty: " + qty);
            Console.ReadLine();
            Console.WriteLine("total amount: " + totalamount );
            Console.ReadLine();
        }
        
    }
}
