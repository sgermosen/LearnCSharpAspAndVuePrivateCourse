<!--<template>
    <div v-if="contact">
        <h1>Edit Contact</h1>
        <form @submit.prevent="editContact">
            <div>
                <label for="name">First Name:</label>
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
                <label for="phoneNumber">Phone Number:</label>
                <input type="text" v-model="contact.phoneNumber" />
            </div>
            <button type="submit">Save Changes</button>
        </form>
    </div>
</template>

<script>
    export default {
        props: ['id'],
        data() {
            return {
                contact: null
            };
        },
        mounted() {
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
                        console.log('Contact updated:', data);
                        this.$emit('contact-updated');
                    });
            }
        }
    };
</script>

<style scoped>
    div {
        margin-bottom: 10px;
    }

    label {
        display: inline-block;
        width: 100px;
    }

    button {
        margin-top: 10px;
    }
</style>-->
<template>
    <div v-if="contact">
        <h2>Edit Contact</h2>
        <form @submit.prevent="editContact" class="mb-3">
            <div class="form-group">
                <label for="name">First Name:</label>
                <input type="text" class="form-control" v-model="contact.name" />
            </div>
            <div class="form-group">
                <label for="lastName">Last Name:</label>
                <input type="text" class="form-control" v-model="contact.lastName" />
            </div>
            <div class="form-group">
                <label for="email">Email:</label>
                <input type="email" class="form-control" v-model="contact.email" />
            </div>
            <div class="form-group">
                <label for="phoneNumber">Phone Number:</label>
                <input type="text" class="form-control" v-model="contact.phoneNumber" />
            </div>
            <button type="submit" class="btn btn-primary">Save Changes</button>
        </form>
    </div>
</template>

<script>
    export default {
        props: ['id'],
        data() {
            return {
                contact: null
            };
        },
        mounted() {
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
                        console.log('Contact updated:', data);
                        this.$emit('contact-updated');
                    });
            }
        }
    };
</script>

<style scoped>
    .form-group {
        margin-bottom: 10px;
    }

    button {
        margin-top: 10px;
    }
</style>
