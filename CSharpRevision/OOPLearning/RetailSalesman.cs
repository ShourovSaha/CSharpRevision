using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLearning
{
    public class RetailSalesman : Salesman, ISelfDeveloping
    {
        public RetailSalesman(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void Develop()
        {
            Console.WriteLine("I've taken reatail sale courses for developing myself.");
        }
    }
}
