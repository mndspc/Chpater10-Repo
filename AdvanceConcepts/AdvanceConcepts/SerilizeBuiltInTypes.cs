using System;
using System.Collections;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AdvanceConcepts
{
    //  This program demo. how serialize in-built types.
    class SerilizeBuiltInTypes
    {
      
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(100,"Hundred");
            ht.Add(1000,"Thousand");

            try
            {
                FileInfo fileInfo = new FileInfo("hashtable.dat");
                FileStream fileStream = fileInfo.Open(FileMode.Create);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, ht);
                fileStream.Close();
                Console.WriteLine("HashTable object is Serialized");
            }catch(SerializationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
