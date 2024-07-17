 
<template>
    <div>
      <h1>Add Contact</h1>
      <form @submit.prevent="addContact">
        <div>
          <label for="name">Name:</label>
          <input type="text" v-model="name" />
        </div>
        <div>
          <label for="lastName">Last Name:</label>
          <input type="text" v-model="lastName" />
        </div>
        <div>
          <label for="email">Email:</label>
          <input type="email" v-model="email" />
        </div>
        <div>
          <label for="address">Address:</label>
          <input type="text" v-model="address" />
        </div>
        <div>
          <label for="phone">Phone:</label>
          <input type="text" v-model="phone" />
        </div>
        <button type="submit">Add Contact</button>
      </form>
    </div>
  </template>
  
  <script>
  /* eslint-disable */
  export default {
    data() {
      return {
        name: '',
        lastName: '',
        email: '',
        address: '',
        phone: ''
      };
    },
    methods: {
      addContact() {
        const newContact = {
          name: this.name,
          lastName: this.lastName,
          email: this.email,
          address: this.address,
          phone: this.phone
        };
  
        fetch('https://localhost:7224/api/contacts', {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json'
          },
          body: JSON.stringify(newContact)
        })
        .then(response => response.json())
        .then(data => {
          this.$router.push('/contacts');
        });
      }
    }
  };
  </script>
  