using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace G_NET_106_Advanced_01
{
    internal class Factory <T> where T : new()
    {
        #region Question09
        /*
         The new() constraint specifies that the type argument T must have a public parameterless constructor. 
         This allows you to instantiate T inside the generic class or method using new T().

         */

        public T Create()
        {
            return new T();
        }

        #endregion
    }
}
