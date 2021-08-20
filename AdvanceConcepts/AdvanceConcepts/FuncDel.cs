using System;


namespace AdvanceConcepts
{
    //  This is generic in-built delegate.
    //  It is like Action delegate but it returns a value
    class FuncDel
    {
        public static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        static void Main()
        {
            Func<int, int,int> obj = Add;
            Console.WriteLine(obj(20,30));
            Console.ReadLine();
        }
    }
}
