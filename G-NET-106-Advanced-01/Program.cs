namespace G_NET_106_Advanced_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            /*
             1) A generic class is a class designed with placeholder type parameters (like Container<T>) so it can operate on any data 
                type specified upon creation. It provides strict type safety by catching type errors at compile time rather than crashing 
                at runtime. Using generics enables code reusability, allowing a single implementation to work with integers, strings
                or custom objects. it boosts performance by avoiding unnecessary type casting and eliminating memory overhead like
                boxing and unboxing.
             
             */

            #endregion


            #region Question02
            Container<int> container01 = new Container<int>();

            container01.Add(60);

            container01.Add(70);

            Console.WriteLine(container01.Get(1));
         

            #endregion
        }
    }
}
