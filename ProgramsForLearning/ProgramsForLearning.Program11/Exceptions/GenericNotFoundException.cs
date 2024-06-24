using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsForLearning.Program11.Exceptions
{
    public class GenericNotFoundException <T> :  Exception where T : class
    {
        public GenericNotFoundException(string message): base(message)
        {
            
        }
    }
}
