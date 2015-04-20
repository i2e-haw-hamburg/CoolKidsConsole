using System;

namespace CoolKidsConsole.Layout.Elements
{
    class BasePanel : APanel<String>
    {
        private String content = "";

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
            var offsetX = x1 + 3;
            var offsetY = y1 + 3;
            var maxLineLength = Width - 6;
            var maxLines = Height - 6;

            var chunks = ChunksUpto(content, maxLineLength);
            foreach (var chunk in chunks)
            {
                DrawSimple(offsetX, offsetY, chunk);
                offsetY++;
            }
        }
    }
}
