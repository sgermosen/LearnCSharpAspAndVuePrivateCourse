 
<template>
    <div v-if="contact">
      <h1>Edit Contact</h1>
      <form @submit.prevent="editContact">
        <div>
          <label for="name">Name:</label>
          <input type="text" v-model="contact.name" />
        </div>
        <div>
          <label for="lastName">Last Name:</label>
          <input type="text" v-model="contact.lastName" />
        </div>
        <div>
          <label for="email">Email:</label>
          <input type="email" v-model="contact.email" />
        </div>
        <div>
          <label for="address">Address:</label>
          <input type="text" v-model="contact.address" />
        </div>
        <div>
          <label for="phone">Phone:</label>
          <input type="text" v-model="contact.phone" />
        </div>
        <button type="submit">Save Changes</button>
      </form>
    </div>
  </template>
  
  <script>
  /* eslint-disable */
  export default {
    props: ['id'],
    data() {
      return {
        contact: null
      };
    },
    created() {
      this.fetchContact();
    },
    methods: {
      fetchContact() {
        fetch(`https://localhost:7224/api/contacts/${this.id}`)
          .then(response => response.json())
          .then(data => {
            this.contact = data;
          });
      },
      editContact() {
        fetch(`https://localhost:7224/api/contacts/${this.id}`, {
          method: 'PUT',
          headers: {
            'Content-Type': 'application/json'
          },
          body: JSON.stringify(this.contact)
        })
        .then(response => response.json())
        .then(data => {
          this.$router.push('/contacts');
        });
      }
    }
  };
  </script>
  