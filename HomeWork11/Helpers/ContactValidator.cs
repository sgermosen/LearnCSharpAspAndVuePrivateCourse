using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsForLearning.HomeWork11.Helpers
{
    public static class ContactValidator
    {
        public static void Validate(Contact contact)
        {
            if (string.IsNullOrWhiteSpace(contact.Name))
            {
                throw new ArgumentException("Name is required.");
            }
            if (string.IsNullOrWhiteSpace(contact.LastName))
            {
                throw new ArgumentException("Last name is required.");
            }
            if (string.IsNullOrWhiteSpace(contact.Email))
            {
                throw new ArgumentException("Email is required.");
            }
        }
    }

}
