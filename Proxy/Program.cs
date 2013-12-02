/*
 
 The Proxy pattern supports objects that control the creation of and access to other objects.
  
 */

using System;

namespace DesignPatterns.Structural.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Proxy();

            Console.WriteLine(subject.Request());
            Console.WriteLine(subject.Request());


            subject = new ProtectionProxy();

            Console.WriteLine(subject.Request());

            Console.WriteLine((subject as ProtectionProxy).Authenticate("Secret"));
            Console.WriteLine((subject as ProtectionProxy).Authenticate("abcde"));
            Console.WriteLine(subject.Request());

            Console.Read();
        }
    }
}
