using System;


namespace AdvanceConcepts
{
    //A delegate is an object which refers to a method or you can say it is a reference type variable that can hold a reference to the methods.
    class Program
    {
        //1.To declare delegate
        public delegate void DelMath(int firstNum,int secondNum);
        // Methods to work with Delegates
        public void Add(int firstNum,int secondNum)
        {
            Console.WriteLine("The sum is:{0}",firstNum+secondNum);
        }

        public void Sub(int firstNum,int secondNum)
        {
            Console.WriteLine("The result is:{0}",firstNum-secondNum);
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            //  2.To Initial. Delegate
            DelMath myDel = new DelMath(program.Add);
            //  3.To Invoke Delegate
            myDel(20, 30);
            myDel = new DelMath(program.Sub);
            myDel(40,20);
            Console.ReadLine();
        }

    }
}
