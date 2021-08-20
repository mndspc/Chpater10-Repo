using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceConcepts
{
    //  This program demo. how to serialize and De-Serialize object into JSON.
    //  JSON (JavaScript Object Notation) is a lightweight data-interchange format.
    //  It is easy for humans to read and write and easy for machines to parse and generate.
    //  JSON is a text format that is completely language independent.
    //  We can implement JSON Serialization/Deserialization in the following three ways:
    //  1.Using JavaScriptSerializer class
    //  2.Using DataContractJsonSerializer class
    //  3.Using JSON.NET library
    #region   The following are some awesome features.
            //Flexible JSON serializer for converting between.NET objects and JSON.
            //LINQ to JSON for manually reading and writing JSON.
            //High performance, faster than .NET's built-in JSON serializers.
            //Easy to read JSON.
            //Convert JSON to and from XML.
            //Supports.NET 2, .NET 3.5, .NET 4, Silverlight and Windows Phone. 
        #endregion
    class SerDesJson
    {
        static void Main()
        {
            Student student = new Student {RollNo=200,Name="scott" };
            //  To Serialize object to Json using JsonConvert class
            string jsonData = JsonConvert.SerializeObject(student);
            Console.WriteLine("After Serialized Object:{0}",jsonData);

            Student student1 = new Student();
            //  To De-Serialize Json to Object using JsonConvert class
            student1 =JsonConvert.DeserializeObject<Student>(jsonData);
            Console.WriteLine("RollNo={0}\t name={1}",student1.RollNo,student1.Name);
            Console.ReadLine();
        }
    }
}
