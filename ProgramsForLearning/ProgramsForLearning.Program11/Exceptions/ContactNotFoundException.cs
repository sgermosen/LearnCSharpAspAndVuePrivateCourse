using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsForLearning.Program11.Exceptions
{
    public class ContactNotFoundException: Exception
    {
        public ContactNotFoundException(string message): base(message)
        {
            
        }
    }
}
