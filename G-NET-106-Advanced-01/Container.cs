using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_Advanced_01
{
    internal class Container<T>
    {
        #region Question02
        private readonly List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
            {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            return items[index];
        }

        #endregion
    }
}
