using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace AdvanceConcepts
{
    // This program demo how Serialize and De-Serialize object of an Employee class.
    class SeriAndDeser
    {
        public void DoSerialization()
        {
            try
            {
                Employee emp = new Employee { EmpCode = 100, EmpName = "Scott", Email = "scott@gmail.com" };
                FileInfo fileInfo = new FileInfo("employee.dat");
                FileStream fileStream = fileInfo.Open(FileMode.Create);
                //Serializes and deserializes an object, or an entire graph of connected objects, in binary format.
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, emp);
                fileStream.Close();
                Console.WriteLine("Employee object is Serialized");
            }catch(SerializationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DoDeserialization()
        {
            try
            {
                Employee emp = new Employee();
                FileInfo fileInfo = new FileInfo("employee.dat");
                FileStream fileStream = fileInfo.Open(FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                emp = (Employee)binaryFormatter.Deserialize(fileStream);
                Console.WriteLine("Code={0}\tName={1}\tEmail={2}", emp.EmpCode, emp.EmpName, emp.Email);
            }catch(SerializationException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main()
        {
            SeriAndDeser seriAndDeser = new SeriAndDeser();
            seriAndDeser.DoSerialization();
            seriAndDeser.DoDeserialization();
            Console.ReadLine();
        }
    }
}
