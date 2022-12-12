namespace BridgePattern_01.Implementation
{
    // Each Concrete Implementation corresponds to a specific platform and
    // implements the Implementation interface using that platform's API.
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplmentationA: The result in platform A.\n";
        }
    }
}