using ProgramsForLearning.Program11.Exceptions;
using ProgramsForLearning.Program11.Models;
namespace ProgramsForLearning.Program11.Helpers.Validators
{
    public static class ContactValidator
    {
        public static void Valitate(Contact contact)
        {
            if (string.IsNullOrEmpty(contact.Name))
            {
                // Console.WriteLine("El nombre es requerido");
                var myError = new ContactIncompleteInformationException("El nombre es requerido");
                myError.ContactId = contact.Id;
                throw myError;
            }
            if (string.IsNullOrEmpty(contact.LastName))
            {
                throw new ArgumentException("El apellido es requerido");
            }
        }
    }
}
