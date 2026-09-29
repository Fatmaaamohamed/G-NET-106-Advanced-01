using static System.Runtime.InteropServices.JavaScript.JSType;

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


            #region Question03
            /*Multiple type parameters allow a generic class, interface, or method to accept more than one placeholder type(e.g., Pair<TKey, TValue>),
             enabling operations on relationships between different data types in a single structure.*/

            Pair<string, int> pair = new Pair<string, int>("Fatma", 1);
            Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
            #endregion


            #region Question04
            /* A generic method is a method declared with its own type parameters allowing it to operate on different data types without belonging to 
             a generic class. The compiler can often infer the type parameter automatically based on the arguments passed to the method*/

            string b = "Advanced";

            string a = "C#";

            Helper.Swap(ref a, ref b);

            Console.WriteLine($"{a} {b}");
            #endregion


            #region Question05

            int[] arr = { 1, 5, 9, 6, 7, 4 };
            Console.WriteLine($"Max num is :  { Helper.FinddMax(arr)}");

            #endregion


            #region Question09

            Factory<Product> factory = new Factory<Product>();

            Product item = factory.Create();

            #endregion
        }
    }
}
