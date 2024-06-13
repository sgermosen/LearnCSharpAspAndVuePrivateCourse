using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProgramsForLearning.Program5.Models
{
    public partial class Person
    {
        public string GetFullName()
        {
            return $"{Name} {LastName}";
        }
        public void MessageFromPartial()
        {
            Console.WriteLine("Esto es un mensaje desde una clase parcial");
        }
    }
}
