using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite
{
    public abstract class AComponent
    {
        protected string name;

        public AComponent(string name)
        {
            this.name = name;
        }

        public abstract void Display(int depth);
    }
}
