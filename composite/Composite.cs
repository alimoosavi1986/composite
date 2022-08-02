using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite
{
    public class Composite : AComponent
    {
        private List<AComponent> _children = new List<AComponent>();

        public Composite(string name) : base(name) { }

        public void Add(AComponent component)
        {
            _children.Add(component);
        }

        public void Remove(AComponent component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (AComponent component in _children)
            {
                component.Display(depth + 2);
            }
        }

    }
}
