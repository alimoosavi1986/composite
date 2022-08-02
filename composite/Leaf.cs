using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite
{
    public class Leaf : AComponent
    {
        public Leaf(string name) : base(name) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

    }
}
