using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas_MyButtons
{
    class MyButtonHeightComparer : IComparer<MyButton>
    {
        public int Compare(MyButton x, MyButton y)
        {
            return x.GetHeight() - y.GetHeight();
        }
    }
}
