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

        #region Question05
        public static T FinddMax<T>(T[] items) where T : IComparable
        {
            T max = items[0];
            for (int i =1; i < items.Length; i++)
            {
                if (items[i].CompareTo(max)>0)
                {
                    max = items[i];
                }
            }

            return max;
        }

        #endregion
    }
}
