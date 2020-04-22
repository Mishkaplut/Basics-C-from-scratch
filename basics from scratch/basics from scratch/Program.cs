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
            int UserAge = Convert.ToInt32(Console.ReadLine());
            switch(UserAge)
            {
                case 12:
                    Console.WriteLine("Too young");
                    break;

                case 16:
                    Console.WriteLine("Nice");
                    break;
                default:
                    Console.WriteLine("Hmmmm");
                    break;
            }
            Console.WriteLine("Goodbay");
        }
    }
}
