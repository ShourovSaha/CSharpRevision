using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading2
{
    public class PatientDetails
    {
        public PatientDetails()
        {
            Console.WriteLine("in the ctor");
        }

        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public string GetFullName()
        {
            return String.Format("{0} {1}", FName, LName);
        }
    }
}
