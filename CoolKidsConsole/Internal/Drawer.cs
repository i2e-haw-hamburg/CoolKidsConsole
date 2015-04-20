using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using CoolKidsConsole.Layout.Elements;

namespace CoolKidsConsole.Internal
{
    class Drawer
    {
        public IList<IUpdatable> panels;
        private Thread t;
        private bool run = true;

        public Drawer() : this(80, 50)
        {
            
        }

        public Drawer(int width, int height)
        {
            Console.SetWindowSize(width, height+1);
            Console.CursorVisible = false;
            panels = new List<IUpdatable>();
            Console.Clear();
            Console.CancelKeyPress += Stop;
            t = new Thread(RunLoop);
            t.Start();
        }

        private void RunLoop()
        {
            while (run)
            {
                foreach (var panel in panels.Where(panel => panel.NeedUpdate()))
                {
                    panel.Update();
                }
                Thread.Sleep(30);
            }
            Console.SetCursorPosition(Console.WindowHeight, 0);
            Console.Clear();
            Console.CursorVisible = true;
        }

        public void Stop(object sender, ConsoleCancelEventArgs consoleCancelEventArgs)
        {
            run = false;
            t.Join();
        }
    }
}
