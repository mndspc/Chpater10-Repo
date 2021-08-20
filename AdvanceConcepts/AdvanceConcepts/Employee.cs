using System;


namespace AdvanceConcepts
{
    [Serializable]
   public class Employee
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }

        //[NonSerialized]
        private string EmpEmail;
        public string  Email { get { return EmpEmail; }set { EmpEmail = value; } }
    }
}
