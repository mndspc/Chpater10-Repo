using System;


namespace AdvanceConcepts
{
    //  This program demo. how to create method without name.
    //  Anonymous method can be defined using the delegate keyword and can be assigned to a variable of del type.
    class AnonyMethod
    {
        public delegate void Print(int value);
        static void Main()
        {
            // C# 2.0: A delegate can be initialized with
            // inline code, called an "anonymous method." This
            Print printDel = delegate (int value)
              {
                  Console.WriteLine("Anonymous methods print value:{0}", value);
              };
            printDel(100);

            // C# 3.0. A delegate can be initialized with
            // a lambda expression. The lambda also takes a int
            // as an input parameter (x). The type of x is inferred by the compiler.
            Print printDel1 = (x) => { Console.WriteLine("Anonymous methods with lambda print value:{0}",x); };
            printDel1(200);

            // How to use Action Delegate to create Anonymous function
            Action<int> actionDel = delegate (int val)
              {
                  Console.WriteLine("Anonymous methods with Action Delegate print value:{0}", val);
              };
            actionDel(300);

             // lambda expression with Action Delegate
             Action<int> actionDel1=i=> Console.WriteLine("Lambda expression with Action Delegate print value:{0}", i);
            actionDel1(500);
            Console.ReadLine();
        }
    }
}
