using System;

namespace AdvanceConcepts
{
    //  This program demo. how to convert int into Nullable type.
    class NullableDemo
    {
        static void Main()
        {
            Nullable<int> num = 10;
            //Console.WriteLine(num.Value);//Error
            if (num.HasValue)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("null");
            }

            int? i = 11;
            i = i ?? 0;
            Console.WriteLine(i);
            Profile user = new Profile { EmpCode = null, Name = "scott" };
            Console.ReadLine();
        }
    }
    class Profile
    {
        public int? EmpCode { get; set; }
        public string Name { get; set; }
    }
}
