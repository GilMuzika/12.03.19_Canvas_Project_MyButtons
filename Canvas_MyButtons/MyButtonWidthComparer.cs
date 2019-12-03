using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas_MyButtons
{
    class MyButtonWidthComparer : IComparer<MyButton>
    {
        public int Compare(MyButton x, MyButton y)
        {
            //return x.GetWidth() - y.GetWidth();

            if (x.GetWidth() == y.GetWidth()) return 0; //zero
            if (x.GetWidth() > y.GetWidth()) return 1; //positive number

            return -1; //negative number
        }
    }
}
