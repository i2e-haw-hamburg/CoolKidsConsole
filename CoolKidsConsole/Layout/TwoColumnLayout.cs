using System;
using System.Collections.Generic;
using CoolKidsConsole.Internal;
using CoolKidsConsole.Layout.Elements;

namespace CoolKidsConsole.Layout
{
    class TwoColumnLayout : ILayout
    {
        private Drawer _drawer;
        public APanel<String> header;
        public APanel<String> left;
        public APanel<IList<String>> right;

        public TwoColumnLayout(int width, int height)
        {
            _drawer = new Drawer(width, height);
            header = new Header(0, 0, width, 6);
            left = new BasePanel(0, 6, width / 2, height);
            right = new ListPanel(width / 2, 6, width, height);
            _drawer.panels.Add(header);
            _drawer.panels.Add(left);
            _drawer.panels.Add(right);
        }

        public void SetTitle(string title)
        {
            header.Content = title;
        }

        public void Update(IList<string> content)
        {
            right.Content = content;
        }

        public void Update(String content)
        {
            left.Content = content;
        }
    }
}
