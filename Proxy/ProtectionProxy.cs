using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    class ProtectionProxy : ISubject
    {
        private Subject _subject;
        private const string Password = "abcde";

        public string Request()
        {
            if (_subject==null)
                return "Protection Proxy: Authenticate first";
            return "Protection Proxy: Call to "+ _subject.Request( );
        }

        public string Authenticate(string supplied)
        {
            if (supplied != Password)
                return "Protection proxy: No access";
        
            _subject = new Subject();
            return "Protection proxy: Authenticated";
        }
    }
}
