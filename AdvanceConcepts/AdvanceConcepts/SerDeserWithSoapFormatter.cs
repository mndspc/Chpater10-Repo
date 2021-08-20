using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace AdvanceConcepts
{
    //  This program demo. how to serialized and de-serialized object using SoapFormatter
    //  The SoapFormatter class to SOAP serialize objects to XML and deserialize from XML back into objects.
    class SerDeserWithSoapFormatter
    {
        static void Main()
        {
            Employee emp = new Employee { EmpCode = 100,EmpName="Scott",Email="scott@gmail.com" };
            FileInfo fileInfo = new FileInfo("employee.xml");
            FileStream fileStream = fileInfo.Open(FileMode.Create);
            //  Serialize with SOAP formatter
            SoapFormatter soapFormatter = new SoapFormatter();
            soapFormatter.Serialize(fileStream, emp);
            fileStream.Close();
            Console.WriteLine("Object is serialized using SoapFormatter");

            Employee emp1 = new Employee();
            FileStream fileStream1 = fileInfo.Open(FileMode.Open);
            //  De-Serialized with SOAP formatter
            SoapFormatter soapFormatter1 = new SoapFormatter();
            emp1 =(Employee) soapFormatter1.Deserialize(fileStream1);
            Console.WriteLine("Code={0}\tName={1}\tEmail={2}",emp1.EmpCode,emp1.EmpName,emp1.Email);

            Console.ReadLine();
        }
    }
}
