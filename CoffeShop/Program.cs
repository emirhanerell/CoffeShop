using CoffeShop.Abstract;
using CoffeShop.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Entities.Customer { FirstName = "Emirhan", LastName = "EREL", NationalityId = 12345678901 ,DateOfBirth = 2002});
            Console.Readline();
        }
    }
}
