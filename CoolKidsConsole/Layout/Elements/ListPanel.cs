using System;
using System.Collections.Generic;

namespace CoolKidsConsole.Layout.Elements
{
    class ListPanel : APanel<IList<String>>
    {
        private IList<string> content;

        public ListPanel(int x1, int y1, int x2, int y2)
            : base(x1, y1, x2, y2)
        {
        }

        public override IList<String> Content
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
            if (content == null)
            {
                return;
            }
            var offsetX = x1 + 4;
            var offsetY = y1 + 5;
            foreach (var str in content)
            {
                DrawSimple(offsetX, offsetY, str);
                offsetY++;
            }
        }
    }
}
