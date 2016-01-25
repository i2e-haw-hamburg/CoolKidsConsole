using System;
using System.Collections.Generic;

namespace CoolKidsConsole.Layout.Elements
{
    abstract class APanel<T> : IUpdatable
    {
        protected int x1;
        protected int y1;
        protected int x2;
        protected int y2;
        protected bool hasBorder = true;
        protected bool isDirty = true;

        private char borderChar = '*';

        public APanel(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public bool NeedUpdate()
        {
            return isDirty;
        }

        public void Update()
        {
            Clear();
            if (hasBorder)
            {
                DrawBorder();
            }
            DrawContent();
            isDirty = false;
        }

        private void Clear()
        {
            for (var i = y1; i < y2; i++)
            {
                Console.SetCursorPosition(x1, i);
                Console.Write(new string(' ', Width - 1));
            }
        }

        public int Width
        {
            get { return x2 - x1; }
        }

        public int Height
        {
            get { return y2 - y1; }
        }

        public abstract T Content { get; set; }

        protected void DrawBorder()
        {
            Console.SetCursorPosition(x1, y1);
            Console.Write(new string(borderChar, Width));
            for (var i = y1+1; i < y2; i++)
            {
                Console.SetCursorPosition(x1, i);
                Console.Write(borderChar);
                Console.SetCursorPosition(x2-1, i);
                Console.Write(borderChar);
            }
            Console.SetCursorPosition(x1, y2);
            Console.Write(new string(borderChar, Width));
        }

        protected static void DrawSimple(int x, int y, string s)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        protected static IEnumerable<string> ChunksUpto(string str, int maxChunkSize)
        {
            for (int i = 0; i < str.Length; i += maxChunkSize)
                yield return str.Substring(i, Math.Min(maxChunkSize, str.Length - i));
        }

        protected abstract void DrawContent();
    }
}
