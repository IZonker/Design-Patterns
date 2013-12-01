using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class CompnonentA : IComponent
    {
        public string Operation()
        {
            return "Behavior of component A";
        }
    }
}
