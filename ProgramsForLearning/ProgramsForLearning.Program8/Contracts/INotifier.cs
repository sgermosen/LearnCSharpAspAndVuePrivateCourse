using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsForLearning.Program8.Contracts
{
    public interface INotifier
    {
        void Send(string message);
    }
}
