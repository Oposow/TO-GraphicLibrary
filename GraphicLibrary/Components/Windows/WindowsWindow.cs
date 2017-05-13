using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary.Components.Windows
{
    public class WindowsWindow : Window
    {
        public WindowsWindow(Rectangle rectangle) : base(rectangle) { }

        public override void Minimize()
        {
            IsMinimalized = true;
            Console.WriteLine("Windows window minimized");
        }

        public override void Maximize()
        {
            IsMinimalized = false;
            Console.WriteLine("Windows window maximized");
        }

        public override void Print()
        {
            if (IsMinimalized)
                Console.WriteLine("Windows window is minimized");
            else
                Console.WriteLine("Windows window maximized. {0}", Rectangle.GetInfo());
        }
    }
}
