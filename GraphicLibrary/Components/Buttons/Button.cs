using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary.Components.Buttons
{
    public abstract class Button : Component
    {
        public Button(Rectangle rectangle) : base(rectangle) { }
        public abstract void Press();
    }
}
