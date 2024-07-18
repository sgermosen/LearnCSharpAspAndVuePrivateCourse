<template>
  <div>
    <h1>Contacts</h1>
    <router-link to="/contacts/add" class="btn btn-primary mb-3">Add New Contact</router-link>
    <ul class="list-group">
      <li v-for="contact in contacts" :key="contact.contactId" class="list-group-item d-flex justify-content-between align-items-center">
        <span>{{ contact.name }} {{ contact.lastName }}</span>
        <span>
          <router-link :to="{ name: 'EditContact', params: { id: contact.contactId } }" class="btn btn-warning btn-sm">Edit</router-link>
          <button @click="deleteContact(contact.contactId)" class="btn btn-danger btn-sm">Delete</button>
        </span>
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
