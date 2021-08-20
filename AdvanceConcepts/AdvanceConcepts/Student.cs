using System;
using System.Runtime.Serialization;

namespace AdvanceConcepts
{
    [DataContract]
  public  class Student
    {
        [DataMember]
        public int RollNo { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
