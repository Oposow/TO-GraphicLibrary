using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary.Components.Windows
{
    public class LinuxWindow : Window
    {
        public LinuxWindow(Rectangle rectangle) : base(rectangle) { }

        public override void Minimize()
        {
            IsMinimalized = true;
            Console.WriteLine("Linux window minimized");
        }

        public override void Maximize()
        {
            IsMinimalized = false;
            Console.WriteLine("Linux window maximized");
        }

        public override void Print()
        {
            if (IsMinimalized)
                Console.WriteLine("Linux window is minimized");
            else
                Console.WriteLine("Linux window maximized. {0}", Rectangle.GetInfo());
        }
    }
}
