using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLearning
{
    public class WebDeveloper : Developer, ISelfDeveloping
    {
        public WebDeveloper(string codingLanguage) : base(codingLanguage)
        {
        }

        public void Develop()
        {
            Console.WriteLine("I've taken Udemy courses for developing myself.");
        }
    }
}
