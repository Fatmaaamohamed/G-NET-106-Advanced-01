using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_Advanced_01
{
    internal class DataManager<T> where T : class
    {
        #region Question08

        /*
         The class constraint specifies that the type argument T must be a reference type (such as a string, class, interface, or delegate).
         It prevents value types (like int, double, or custom structs) from being passed.
         
         */

        public T Data { get; set; }

        public DataManager(T data)
        {
            Data = data;
        }

        #endregion
    }
}
