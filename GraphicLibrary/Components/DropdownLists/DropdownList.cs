using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary.Components.DropdownLists
{
    public abstract class DropdownList : Component
    {
        public DropdownList(Rectangle rectangle) : base(rectangle)
        {
            IsRolled = true;
        }

        protected bool IsRolled;

        public abstract void Unroll();
        public abstract void Roll();
    }
}
