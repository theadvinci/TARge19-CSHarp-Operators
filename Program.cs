using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 2;

            //Arithmetic Operators
            //Multiple Line Comment
            /*Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);*/

            Console.WriteLine(x = y);
            x = 5;
            y = 2;
            Console.WriteLine(x += y);
            x = 5;
            y = 2;
            Console.WriteLine(x -= y);
            x = 5;
            y = 2;
            Console.WriteLine(x *= y);
            x = 5;
            y = 2;

            // Jäägi leidmine. Mitu korda y mahub x-i sisse.
            Console.WriteLine(x % y);


            /*
            //Comparison operators
            // X = Y
            Console.WriteLine(x == y);

            // X EI = Y
            Console.WriteLine(x != y);

            // X > Y
            Console.WriteLine(x > y);

            // X > või = Y
            Console.WriteLine(x >= y); */

            //Logical operators
            // && - AND
            // || - OR
            Console.WriteLine(x != y && y == 2);

            Console.WriteLine(x != y || y == 10);

            Console.WriteLine(!(y == 10));





            Console.ReadLine();

        }
    }
}