using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsForLearning.Program11.Exceptions
{
    public class ContactIncompleteInformationException: ArgumentException
    {
        public int ContactId { get; set; }
        public ContactIncompleteInformationException(string message): base(message)
        {
            
        }

    }
}
