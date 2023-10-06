using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{

    class accounts
    {

        private int accountno;
        private string customername;
        private string accounttype;
        private char transactiontype;
        private double amount;
        private double balance;
        public accounts(int accountno, string customername, string accounttype, char transactiontype, double amount)
        {
            this.accountno = accountno;
            this.customername = customername;
            this.accounttype = accounttype;
            this.transactiontype = transactiontype;
            this.amount = amount;
            this.balance = 0;
        }

        public void credits(double depositamount)
        {
            if (depositamount > 0)
            {
                balance += depositamount;
                Console.WriteLine($"deposited: ${depositamount}");
            }
            else
            {
                Console.WriteLine("invaild depoist amount.");
            }
        }
        public void Debit(double withdrawamount)
        {
            if (withdrawamount > 0 && withdrawamount <= balance)
            {
                balance -= withdrawamount;
                Console.WriteLine($"withdrawn: ${withdrawamount}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawamount or insufficient balance.");
            }
        }
        public void showdata()
        {
            Console.WriteLine($"accountno: ${accountno}");
            Console.WriteLine($"customer name: ${customername}");
            Console.WriteLine($"accounttype: ${accounttype}");
            Console.WriteLine($"transaction type: ${transactiontype}");
            Console.WriteLine($"accountno: ${accountno}");
            Console.WriteLine($"current balance: ${balance:c}");

        }


    }
}

