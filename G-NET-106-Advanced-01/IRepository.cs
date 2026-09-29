using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_Advanced_01
{
    internal interface IRepository<T>
    {
        #region Question06

        /* A generic interface is an interface defined with type parameters, allowing you to define a single standard contract that 
        operates on any specific data type while keeping strict type safety.*/


        void Add(T item);

        T GetById(int id);


        #endregion
    }
}
