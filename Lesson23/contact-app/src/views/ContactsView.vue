
<template>
    <div>
      <h1>Contacts</h1>
      <router-link to="/contacts/add">Add New Contact</router-link>
      <ul>
        <li v-for="contact in contacts" :key="contact.contactId">
          {{ contact.name }} {{ contact.lastName }}
          <router-link :to="{ name: 'EditContact', params: { id: contact.contactId } }">Edit</router-link>
          <button @click="deleteContact(contact.contactId)">Delete</button>
        </li>
      </ul>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        contacts: []
      };
    },
    created() {
      this.fetchContacts();
    },
    methods: {
      fetchContacts() {
        fetch('https://localhost:7224/api/contacts')
          .then(response => response.json())
          .then(data => {
            this.contacts = data.contacts;
          });
      },
      deleteContact(id) {
        fetch(`https://localhost:7224/api/contacts/${id}`, {
          method: 'DELETE'
        })
        .then(() => {
          this.fetchContacts();
        });
      }
    }
  };
  </script>
  