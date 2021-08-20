using System;


namespace AdvanceConcepts
{
    // A predicate delegate is an in-built generic type delegate.
    // It works with those methods which contain some set of criteria and determine whether the passed parameter fulfill the given criteria or not.
    //  It can accept only single parameter.
    class PredicateDelegate
    {
        public static bool Function1(string myStr)
        {
            if (myStr.Length < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {
            Predicate<string> pval = Function1;
            Console.WriteLine(pval("Hello World"));
            Console.ReadLine();
        }
    }
}
