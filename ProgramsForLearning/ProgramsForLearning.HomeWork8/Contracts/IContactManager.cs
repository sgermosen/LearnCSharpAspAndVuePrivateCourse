using ProgramsForLearning.HomeWork8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsForLearning.HomeWork8.Contracts
{
    public interface IContactManager
    {
        //void AddNotification(Contact contact);
        void AddContact(Contact contact);
        void UpdateContact(Contact contact);
        void DeleteContact(int id);
        List<Contact> ListContacts();
    }
}
