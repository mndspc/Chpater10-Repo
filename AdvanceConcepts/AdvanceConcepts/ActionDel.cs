using System;


namespace AdvanceConcepts
{
    //  Action delegate is an in-built generic type delegate.you need not to create custom delegate.
    //  it can contain minimum 1 param. and maximum 16 param.
    //  The Acion delegate generally used for functions which do not return value.
    class ActionDel
    {
        public static void Add(int firstNum,int secondNum)
        {
            Console.WriteLine("The sum is:{0}",firstNum+secondNum);
        }
        
        static void Main()
        {
            Action<int, int> obj = Add;
            obj(20,10);
            Console.ReadLine();
        }
    }
}
