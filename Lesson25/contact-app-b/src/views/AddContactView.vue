<template>
  <div class="container">
    <h1>Add Contact</h1>
    <form @submit.prevent="addContact">
      <div class="mb-3">
        <label for="name" class="form-label">Name:</label>
        <input type="text" v-model="name" class="form-control" />
      </div>
      <div class="mb-3">
        <label for="lastName" class="form-label">Last Name:</label>
        <input type="text" v-model="lastName" class="form-control" />
      </div>
      <div class="mb-3">
        <label for="email" class="form-label">Email:</label>
        <input type="email" v-model="email" class="form-control" />
      </div>
      <div class="mb-3">
        <label for="address" class="form-label">Address:</label>
        <input type="text" v-model="address" class="form-control" />
      </div>
      <div class="mb-3">
        <label for="phone" class="form-label">Phone:</label>
        <input type="text" v-model="phone" class="form-control" />
      </div>
      <button type="submit" class="btn btn-primary">Add Contact</button>
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
