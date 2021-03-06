﻿using System;
using System.Collections.Generic;
using CoolKidsConsole.Internal;
using CoolKidsConsole.Layout.Elements;

namespace CoolKidsConsole.Layout
{
    class BaseLayout : ILayout
    {
        private Drawer _drawer;
        public APanel<String> header;
        public APanel<String> main;

        public BaseLayout(int width, int height)
        {
            _drawer = new Drawer(width, height);
            header = new Header(0, 0, width, 6);
            main = new BasePanel(0, 6, width, height);
            _drawer.panels.Add(header);
            _drawer.panels.Add(main);
        }

        public void SetTitle(string title)
        {
            header.Content = title;
        }

        public void Update(IList<string> content)
        {
            
        }

        public void Update(String content)
        {

        }
    }
}
