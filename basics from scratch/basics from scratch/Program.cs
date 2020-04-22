using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics_from_scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserSex = Console.ReadLine();
            string UserName = Console.ReadLine();

            UserName = (UserSex == "Male" ? "Mr" : "Mrs") + UserName;

            Console.WriteLine(UserName);

            Console.WriteLine("Goodbay");

            Console.ReadKey();
        }
    }
}
