using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_Advanced_01
{
    public class Printer<T> where T : IPrintable
    {
        #region Question10
        public void Display(T item)
        {
            item.Print(); 
        }
        #endregion
    }
}
