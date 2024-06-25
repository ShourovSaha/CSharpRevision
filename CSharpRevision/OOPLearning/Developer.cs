using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLearning
{
    public abstract class Developer
    {
        private string _codingLanguage;
        public Developer(string codingLanguage)
        {
            _codingLanguage = codingLanguage;
        }

        public virtual void Code()
        {
            Console.WriteLine(String.Format("My main dev language is {0}.", _codingLanguage));
        }
        public virtual void Code(string extraDevLanguage)
        {
            Console.WriteLine(String.Format("My main dev language is {0} and 2nd dev language is {1}", _codingLanguage, extraDevLanguage));
        }

        public virtual void Code(string firstExtraDevLanguage, string secondExtraDevLanguage)
        {
            Console.WriteLine(String.Format("My main dev language is {0} and 1st dev language is {1} and 2nd extra dev language is {2}", _codingLanguage, firstExtraDevLanguage, secondExtraDevLanguage));
        }
    }
}
