using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            //See if throws error number1 :
            //stack.Pop();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            //See if throws error number2 : 
            //stack.Push(null);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            










        }
    }
}
