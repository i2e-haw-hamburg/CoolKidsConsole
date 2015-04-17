﻿using System;
using CoolKidsConsole;

namespace CoolKidsConsoleSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var layout = LayoutFactory.CreateBaseLayout("Hello World");
            AppDomain.CurrentDomain.DomainUnload += new EventHandler(layout.Close());
        }
    }
}
