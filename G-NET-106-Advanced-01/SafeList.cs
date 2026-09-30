using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_Advanced_01
{
    internal class SafeList<T>
    {

        #region Question14

        public readonly List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }


        public T GetAt (int index)
        {
            if (index < 0 || index >= items.Count)
            {
                return default;
            }

            else

                return items[index];
        }

        #endregion
    }
}
