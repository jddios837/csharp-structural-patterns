using System;
using Facade_Pattern_01.Library;

namespace Facade_Pattern_01
{
    class Program
    {
        static void Main(string[] args)
        {
            SubSystem1 subsystem1 = new();
            SubSystem2 subsystem2 = new();

            Facade facade = new(subsystem1, subsystem2);
            
            Client.ClientCode(facade);
        }
    }
}