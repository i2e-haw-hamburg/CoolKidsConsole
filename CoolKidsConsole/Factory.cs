using CoolKidsConsole.Layout;

namespace CoolKidsConsole
{
    public class Factory
    {
        public static ILayout CreateBaseLayout(string title = "")
        {
            var l = new BaseLayout(100, 50);
            l.SetTitle(title);
            return l;
        }
    }
}
