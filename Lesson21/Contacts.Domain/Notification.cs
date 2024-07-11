using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Domain
{
    public class Notification
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }

}
