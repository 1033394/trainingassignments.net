using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concession

{
    public class concessioncalculator
    {
        private const double totalfare = 500.0;
        public string calculateconcession(int age,string name)
        {
            if (age <= 5)
            {
                return $"{ name},age:{ age},ticket:little champs-free ticket";
            }
            else if (age > 60)
            {
                double seniorcitizenfare = 0.7 * totalfare;
                return $"{ name},age:{ age},ticket:senior citizen {seniorcitizenfare:c}";
            }
            else
            {
                return $"{ name},age:{ age},ticket:ticket booked-{totalfare:c}";
            }
        }
    }
}

