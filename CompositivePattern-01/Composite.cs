using System.Collections.Generic;

namespace CompositivePattern_01
{
    class Composite : Component
    {
        protected List<Component> _children = new();

        public override void Add(Component component)
        {
            this._children.Add(component);
        }

        public override void Remove(Component component)
        {
            this._children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Component c in this._children)
            {
                result += c.Operation();
                if (i != this._children.Count - 1)
                {
                    result += "+";
                }

                i++;
            }

            return result + ")";
        }
    }
}