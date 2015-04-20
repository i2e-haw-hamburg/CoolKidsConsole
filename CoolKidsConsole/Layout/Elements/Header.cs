using System;

namespace CoolKidsConsole.Layout.Elements
{
    class Header : APanel<String>
    {
        private String content;
        
        public Header(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
        }

        public override String Content
        {
            set
            {
                content = value;
                isDirty = true;
            }
            get { return content; }
        }

        protected override void DrawContent()
        {
            var offsetY = Height/2;
            var offsetX = (Width - content.Length)/2;
            DrawSimple(x1 + offsetX, y1 + offsetY, content);
        }
    }
}
