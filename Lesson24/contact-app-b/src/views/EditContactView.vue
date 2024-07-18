<template>
  <div class="container" v-if="contact">
    <h1>Edit Contact</h1>
    <form @submit.prevent="editContact">
      <div class="mb-3">
        <label for="name" class="form-label">Name:</label>
        <input type="text" v-model="contact.name" class="form-control" />
      </div>
      <div class="mb-3">
        <label for="lastName" class="form-label">Last Name:</label>
        <input type="text" v-model="contact.lastName" class="form-control" />
      </div>
      <div class="mb-3">
        <label for="email" class="form-label">Email:</label>
        <input type="email" v-model="contact.email" class="form-control" />
      </div>
      <div class="mb-3">
        <label for="address" class="form-label">Address:</label>
        <input type="text" v-model="contact.address" class="form-control" />
      </div>
      <div class="mb-3">
        <label for="phone" class="form-label">Phone:</label>
        <input type="text" v-model="contact.phone" class="form-control" />
      </div>
      <button type="submit" class="btn btn-primary">Save Changes</button>
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
