using CoffeShop.Abstract;
using CoffeShop.Adapters;
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
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer { FirstName = "Emirhanasd", LastName = "EREL", NationalityId = 18901, DateOfBirth = 2001 });
            Console.ReadLine();
        }
    }
}
