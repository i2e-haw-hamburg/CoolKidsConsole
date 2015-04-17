using System;

namespace CoolKidsConsole.Layout.Elements
{
    class BasePanel : APanel
    {
        private String content;

        public BasePanel(int x1, int y1, int x2, int y2)
            : base(x1, y1, x2, y2)
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
            
        }
    }
}
