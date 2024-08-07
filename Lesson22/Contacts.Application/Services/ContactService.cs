﻿using Contacts.Application.Contracts;
using Contacts.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Application.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<List<Contact>> GetAllContacts()
        {
            return await _contactRepository.GetAll();
        }

        public async Task<Contact> GetContactById(int id)
        {
            return await _contactRepository.GetById(id);
        }

        public async Task AddContact(Contact contact)
        {
            await _contactRepository.Add(contact);
        }

        public async Task UpdateContact(Contact contact)
        {
            await _contactRepository.Update(contact);
        }

        public async Task DeleteContact(int id)
        {
            await _contactRepository.Delete(id);
        }

        public async Task<List<Contact>> GetContactsWithAppointments()
        { 
            return await _contactRepository.GetContactsWithAppointments();
        }

        public async Task<List<Contact>> GetContactsWithNotifications()
        {
            return await _contactRepository.GetContactsWithNotifications();
        }
        public async Task<List<Contact>> GetContactsWithNotificationsAndAppointments()
        {
            return await _contactRepository.GetContactsWithNotificationsAndAppointments();
        }
    }

}
