using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_Advanced_01
{
    internal class Calculator<T> where T : struct
    {
        #region Question07

        /* The struct constraint specifies that the type argument T must be a non-nullable value type (such as int,
         * double, bool, or a custom struct). It prevents reference types (like string or classes) and nullable value 
         * types (like int?) from being used with the generic class or method.*/

        public T Value { get; set; }

        public Calculator(T value)
        {
            Value = value;
        }
        #endregion
    }
}
