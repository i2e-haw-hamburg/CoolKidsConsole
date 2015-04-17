using System;
using System.Collections.Generic;
using System.Threading;
using CoolKidsConsole.Layout.Elements;

namespace CoolKidsConsole.Internal
{
    class Drawer
    {
        public IList<APanel> panels;
        private Thread t;
        private bool run = true;

        public Drawer() : this(80, 50)
        {
            
        }

        public Drawer(int width, int height)
        {
            Console.SetWindowSize(width, height+1);
            Console.CursorVisible = false;
            panels = new List<APanel>();
            Console.Clear();
            t = new Thread(RunLoop);
            t.Start();
        }

        private void RunLoop()
        {
            while (run)
            {
                foreach (var panel in panels)
                {
                    if (panel.NeedUpdate())
                    {
                        panel.Update();
                    }
                }
                Console.SetCursorPosition(0, 0);
                Thread.Sleep(30);
            }
            
        }

        public void Stop()
        {
            run = false;
            t.Join();
            Console.Clear();
            Console.CursorVisible = true;
        }
    }
}
