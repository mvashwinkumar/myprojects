using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCFTestPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            WCFService.Service1Client l_client = new WCFService.Service1Client();
            Console.WriteLine(l_client.GetData());
            Console.Read();
        }
    }
}
