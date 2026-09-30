using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace G_NET_106_Advanced_01
{
    internal class Datastore<T> where T : class , new()
    {

        #region Question12
        public T Create()
        {
            return new T();
        }

        #endregion
    }
}
