using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary.Components.Buttons
{
    public class WindowsButton : Button
    {
        public WindowsButton(Rectangle rectangle) : base(rectangle) { }

        public override void Print()
        {
            Console.WriteLine("Windows button. {0}", Rectangle.GetInfo());
        }

        public override void Press()
        {
            Console.WriteLine("Windows button has been pressed");
        }
    }
}
