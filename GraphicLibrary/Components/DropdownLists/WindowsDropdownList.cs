using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary.Components.DropdownLists
{
    class WindowsDropdownList : DropdownList
    {
        public WindowsDropdownList(Rectangle rectangle) : base(rectangle) { }

        public override void Roll()
        {
            IsRolled = true;
            Console.WriteLine("Windows dropdown list rolled");
        }

        public override void Unroll()
        {
            IsRolled = false;
            Console.WriteLine("Windows dropdown list unrolled");
        }

        public override void Print()
        {
            if (IsRolled)
                Console.WriteLine("Windows dropdown list is rolled. {0}", Rectangle.GetInfo());
            else
                Console.WriteLine("Windows dropdown list is unrolled. {0}", Rectangle.GetInfo());
        }
    }
}
