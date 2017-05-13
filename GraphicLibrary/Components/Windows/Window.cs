using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary.Components.Windows
{
    public abstract class Window : Component
    {
        public Window(Rectangle rectangle) : base(rectangle) { }

        protected bool IsMinimalized;

        public abstract void Minimize();
        public abstract void Maximize();
    }
}
