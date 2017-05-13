using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary.Components
{
    public abstract class Component
    {
        public Component(Rectangle rectangle)
        {
            Rectangle = rectangle;
        }

        public abstract void Print();

        protected Rectangle Rectangle;
    }
}
