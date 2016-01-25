using CoolKidsConsole.Layout;

namespace CoolKidsConsole
{
    public class LayoutFactory
    {
        public static ILayout CreateBaseLayout(string title = "")
        {
            var l = new BaseLayout(100, 50);
            l.SetTitle(title);
            return l;
        }

        public static ILayout Create2ColumnLayout(string title = "")
        {
            var l = new TwoColumnLayout(80, 30);
            l.SetTitle(title);
            return l;
        }
    }
}
