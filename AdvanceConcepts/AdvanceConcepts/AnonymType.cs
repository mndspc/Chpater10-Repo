using System;


namespace AdvanceConcepts
{
    // This program demo. how to create anonymous type.
    //  Anonymous type does have any name
    class AnonymType
    {
        static void Main()
        {
            var student = new {RollNo=100,FirstName="Scott",LastName="Tiger" };
            //  Anonymous type contains Readonly properties
            //student.RollNo = 101;

            Console.WriteLine("Roll No={0}\tFirstName={1}\t LastName={2}",student.RollNo,student.FirstName,student.LastName);

            var students = new[]
            {
                new {RollNo=100,FirstName="Scott",LastName="Tiger"},
                new {RollNo=101,FirstName="Smith",LastName="Jhones"},
                new {RollNo=100,FirstName="Adam",LastName="stim" }
            };
            foreach(var std in students)
            {
                Console.WriteLine("Roll No={0}\tFirstName={1}\t LastName={2}", std.RollNo, std.FirstName, std.LastName);
            }
            Console.ReadLine();
        }
    }
}
