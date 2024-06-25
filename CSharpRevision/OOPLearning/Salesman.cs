using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLearning
{
    public abstract class Salesman
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }

        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", _firstName, _lastName);
            }
        }

        public Salesman(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public virtual void Sell()
        {
            Console.WriteLine(String.Format("I'm {0}. Recomending you this item.", FullName));
        }
    }
}
