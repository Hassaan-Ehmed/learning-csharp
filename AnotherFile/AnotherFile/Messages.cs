using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherFile
{
    static class Messages // custom classess
    {

       public static void Hello() {

            Console.WriteLine("Hello Man!");
        }
       public static void Waiting() {

            Console.WriteLine("I'm waiting.....");
        }

        public static void Bye() {
            Console.OutputEncoding = Encoding.UTF8;


            Console.WriteLine("Bye Bye u+1F44B");
        }
    }
}
