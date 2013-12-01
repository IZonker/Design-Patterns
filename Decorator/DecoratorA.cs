using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class DecoratorA : IComponent
    {
        private IComponent _component;

        public DecoratorA(IComponent component)
        {
            _component = component;

        }

        public string Operation()
        {
            string result = _component.Operation();
            result += " Beeing decorated by DecoratorA";
            return result;
        }
    }
}
