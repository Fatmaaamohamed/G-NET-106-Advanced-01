using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_Advanced_01
{
    internal class Helper
    {
        #region Question04
        public static void Swap<T>(ref T a , ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        #endregion
    }
}
