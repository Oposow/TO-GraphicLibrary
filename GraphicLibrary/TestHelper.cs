using System;
using GraphicLibrary.Components;
using GraphicLibrary.Components.Buttons;
using GraphicLibrary.Components.DropdownLists;
using GraphicLibrary.Components.Windows;

namespace GraphicLibrary
{
    public static class TestHelper
    {
        public static void TestLibrary()
        {
            // Linux version
            Console.WriteLine("Testing Linux version");
            Console.WriteLine();

            Button button = new LinuxButton(new Rectangle(20, 40, 50, 30));
            button.Print();
            button.Press();
            Console.WriteLine();

            Window window = new LinuxWindow(new Rectangle(30, 10, 250, 300));
            window.Print();
            window.Minimize();
            window.Print();
            window.Maximize();
            window.Print();
            Console.WriteLine();

            DropdownList dropdownList = new LinuxDropdownList(new Rectangle(60, 70, 200, 600));
            dropdownList.Print();
            dropdownList.Unroll();
            dropdownList.Print();
            dropdownList.Roll();
            dropdownList.Print();
            Console.WriteLine();

            // Windows version
            Console.WriteLine("Testing Windows version");
            Console.WriteLine();

            button = new WindowsButton(new Rectangle(50, 240, 150, 330));
            button.Print();
            button.Press();
            Console.WriteLine();

            window = new WindowsWindow(new Rectangle(170, 130, 550, 350));
            window.Print();
            window.Minimize();
            window.Print();
            window.Maximize();
            window.Print();
            Console.WriteLine();

            dropdownList = new WindowsDropdownList(new Rectangle(160, 270, 240, 500));
            dropdownList.Print();
            dropdownList.Unroll();
            dropdownList.Print();
            dropdownList.Roll();
            dropdownList.Print();
            Console.WriteLine();
        }
    }
}
