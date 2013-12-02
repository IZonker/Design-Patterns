using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class Proxy : ISubject
    {
        private Subject _subject;

        public string Request()
        {
            if (_subject == null)
            {
                Console.WriteLine("Subject inactive");
                _subject = new Subject();
            }
            Console.WriteLine("Subject activated");
            return _subject.Request();
        }
    }
}
