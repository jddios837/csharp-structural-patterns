using System;
using BridgePattern_01.Implementation;

namespace BridgePattern_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Abstraction abstraction;
            
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new Abstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}