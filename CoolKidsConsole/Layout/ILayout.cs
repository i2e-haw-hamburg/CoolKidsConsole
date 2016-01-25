using System;
using System.Collections.Generic;

namespace CoolKidsConsole.Layout
{
    public interface ILayout
    {
        void SetTitle(String title);
        void Update(IList<String> content);
        void Update(String content);
    }
}
