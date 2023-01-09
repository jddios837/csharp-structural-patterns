using Facade_Pattern_01.Library;

namespace Facade_Pattern_01
{
    public class Facade
    {
        protected SubSystem1 _subsystem1;
        protected SubSystem2 _subsystem2;

        public Facade(SubSystem1 subsystem1, SubSystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystem1.Operation1();
            result += this._subsystem2.Operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1.OperationN();
            result += this._subsystem2.OperationZ();

            return result;
        }
    }
}