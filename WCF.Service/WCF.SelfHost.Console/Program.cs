using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.SelfHost.ConsoleClient.ServiceReference1;

namespace WCF.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CustomerServiceClient client = new CustomerServiceClient("wsHttpBinding"))
            {
                Console.WriteLine("WSHttpBinding Started");

                var list = client.GetByKey("0 OR 1=1");

                foreach (var item in list)
                {
                    Console.WriteLine(item.NAME);
                }

                Console.WriteLine("WSHttpBinding Ended");

            }

            using (CustomerServiceClient client = new CustomerServiceClient("netNamedPipeBinding"))
            {
                Console.WriteLine("NetNamedPipeBinding Started");

                var list = client.GetByKey("0 OR 1=1");

                foreach (var item in list)
                {
                    Console.WriteLine(item.NAME);
                }

                Console.WriteLine("NetNamedPipeBinding Ended");
            }
            Console.ReadLine();
        }
    }
}
