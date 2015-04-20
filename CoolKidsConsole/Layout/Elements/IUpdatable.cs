using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolKidsConsole.Layout.Elements
{
    interface IUpdatable
    {
        bool NeedUpdate();
        void Update();
    }
}
