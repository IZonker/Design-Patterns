using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class DecoratorB : IComponent
    {
        private IComponent _component;

        public DecoratorB(IComponent component)
        {
            _component = component;

        }

        public string Operation()
        {
            string result = _component.Operation();
            result += " DecoratorB added a new behavior";
            return result;
        }
    }
}
