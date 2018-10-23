using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Note to teacher!:
//Mycket av koden har vi jobbat tillsammans med, därav ser det väldigt kopierat ut!
namespace Bank
{
    class Customer
    {
        public string name { get; set; }
        public int balance { get; set; }
        public string customerInfo()
        {
            return this.name;
        }
    }
}