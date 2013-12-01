/*
 
 * The Role of Decorator paatern is provide a way of attaching new behavior to an object dynamicaly.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent comp1 = new CompnonentA();
            IComponent decoratorA = new DecoratorA(comp1);
            IComponent decoratorB = new DecoratorB(comp1);
            var result = decoratorA.Operation();

            Console.WriteLine(result);

            Console.Read();
        }
    }
}
