using BridgePattern_01.Implementation;

namespace BridgePattern_01
{   
    // You can extend the Abstraction without changing the Implementation
    // classes.
    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            // return base.Operation();
            return "ExtendedAbstraction: Extended operation with:\n" +
                   base._implementation.OperationImplementation();
        }
    }
}