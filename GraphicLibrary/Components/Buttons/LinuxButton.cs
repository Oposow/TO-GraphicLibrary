using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary.Components.Buttons
{
    public class LinuxButton : Button
    {
        public LinuxButton(Rectangle rectangle) : base(rectangle) { }

        public override void Print()
        {
            Console.WriteLine("Linux button. {0}", Rectangle.GetInfo());
        }

        public override void Press()
        {
            Console.WriteLine("Linux button has been pressed");
        }
    }
}
