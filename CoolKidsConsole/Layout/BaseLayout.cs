using System;
using CoolKidsConsole.Internal;
using CoolKidsConsole.Layout.Elements;

namespace CoolKidsConsole.Layout
{
    class BaseLayout : ILayout
    {
        private Drawer _drawer;
        public APanel header;
        public APanel main;

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

        public void Close(object sender, EventArgs e)
        {
            _drawer.Stop();
        }
    }
}
