using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viva.Facebook;


namespace Viva.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new FacebookProvider();
            System.Console.WriteLine("Getting token...");
            var token = provider.GetToken();
            System.Console.WriteLine("token:" + token);
            System.Console.WriteLine("Press any key");
            System.Console.ReadKey();
        }
    }
}
