using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.Service.SelfHostingLib;

namespace WCF.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerService service = new CustomerService();

            var customerList = service.GetByKey("0 OR 1=1");

            foreach (var item in customerList)
            {
                Console.WriteLine(item.NAME);
            }

            Console.ReadLine();
        }
    }
}
