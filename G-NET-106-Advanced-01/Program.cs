using System.Data.Common;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Intrinsics.X86;
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


            #region Question10
            /*
             The interface constraint specifies that the type argument T must implement a specific interface.
             This guarantees that elements of type T expose the methods and properties defined by that interface.
             
             */
            Printer<Document> printer = new Printer<Document>();

            printer.Display(new Document());


            #endregion


            #region Question11
            /*
             The base class constraint (where T : BaseClass) specifies that the type argument T must be or derive from a specific base class.
             This allows the generic code to access members inherited from that base class.*/


            Shelter<Dog> shelter = new Shelter<Dog>();

            shelter.DisplayName(new Dog() { Name ="LoLo"});

            #endregion


            #region Question12

            /*
             To apply multiple constraints, list them after where T : separated by commas.
             Order Rule: Reference/Value type constraint (class or struct) or Base Class goes first, 
             interfaces in the middle, and new() must be last.             */


            Datastore<User> datastore = new Datastore<User>();
            User newUser = datastore.Create();


            #endregion


            #region Question13
            /*
             In generics, default provides the default initial value of a type parameter T when the exact type is unknown at compile-time.
            Reference types(Null) , Numeric value types(0) , Boolean types(False), 
             
             */


            #endregion


            #region Question14

            SafeList<int> safeList = new SafeList<int>();

            safeList.Add(5);
            safeList.Add(1);
            safeList.Add(7);

            Console.WriteLine(safeList.GetAt(2));

            Console.WriteLine(safeList.GetAt(6));



            #endregion


            #region Question15
            /*  Covariance allows you to use a more derived type(child class) than originally specified by the generic type parameter.
                it applies only to interfaces.
                The out keyword marks a type parameter as covariant.This restricts T so that it can only be used as a return type (output) of methods,
                never as a method parameter input.*/

            #endregion



            #region Question16
            /*  Contravariance allows you to use a less derived type (parent/base class) than originally specified by the generic type parameter.
                It also applies only to interfaces and delegates.
                The in keyword marks a type parameter as contravariant. This restricts T so that it can only be used as a method parameter (input)
                never as a return type output.*/

            #endregion



            #region Question17
            /* Covariance(out): Moves from derived to base type(read - only / output).

               Contravariance(in): Moves from base to derived type(write - only / input).*/
            #endregion


            #region Question18
            /*
             Static members are not shared across different closed generic types. Counter<int> and Counter<string> maintain 
             completely separate static instances in memory.
             
             */

            #endregion



            #region Question19

            /*Provide a specific concrete type(closed generic inheritance).

             Pass through the generic parameter from the derived class to the base class (open generic inheritance).*/

            #endregion
        }
    }
}
