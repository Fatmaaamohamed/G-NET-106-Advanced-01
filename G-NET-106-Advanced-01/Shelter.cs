using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_Advanced_01
{
    internal class Shelter<T> where T : Animal
    {
        #region Question11
        public void DisplayName (T pet)
        {
            Console.WriteLine(pet.Name);
        }
        #endregion
    }
}
