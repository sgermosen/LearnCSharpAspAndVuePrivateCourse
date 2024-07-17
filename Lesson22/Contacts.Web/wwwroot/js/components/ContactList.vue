<!--<template>
    <div>
        <h1>Contact List</h1>
        <ul>
            <li v-for="contact in contacts" :key="contact.id">
                {{ contact.name }} {{ contact.lastName }}
                <button @click="editContact(contact.id)">Edit</button>
                <button @click="deleteContact(contact.id)">Delete</button>
            </li>
        </ul>
        <edit-contact v-if="editingContactId" :id="editingContactId" @contact-updated="fetchContacts"></edit-contact>
    </div>
</template>

<script>
    import EditContact from './EditContact.vue';

    export default {
        components: {
            EditContact
        },
        data() {
            return {
                contacts: [],
                editingContactId: null
            };
        },
        mounted() {
            this.fetchContacts();
        },
        methods: {
            fetchContacts() {
                fetch('https://localhost:7224/api/contacts')
                    .then(response => response.json())
                    .then(data => {
                        this.contacts = data;
                    });
            },
            editContact(id) {
                this.editingContactId = id;
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

<style scoped>
    ul {
        list-style-type: none;
        padding: 0;
    }

    li {
        background: #f4f4f4;
        margin: 10px 0;
        padding: 10px;
        border: 1px solid #ccc;
    }

    button {
        margin-left: 10px;
    }
</style>-->

<template>
    <div>
        <h1>Contact List</h1>
        <button class="btn btn-primary mb-3" @click="toggleAddContact">
            {{ showAddContact ? 'Hide Add Contact' : 'Show Add Contact' }}
        </button>
        <add-contact v-if="showAddContact" @contact-added="fetchContacts"></add-contact>
        <table class="table table-striped">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Phone</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="contact in contacts" :key="contact.contactId">
                    <td>{{ contact.name }} {{ contact.lastName }}</td>
                    <td>{{ contact.email }}</td>
                    <td>{{ contact.phone }}</td>
                    <td>
                        <button class="btn btn-warning btn-sm" @click="editContact(contact.contactId)">Edit</button>
                        <button class="btn btn-danger btn-sm" @click="deleteContact(contact.contactId)">Delete</button>
                    </td>
                </tr>
            </tbody>
        </table>
        <edit-contact v-if="editingContactId" :id="editingContactId" @contact-updated="fetchContacts"></edit-contact>
    </div>
</template>

<script>
    import AddContact from './AddContact.vue';
    import EditContact from './EditContact.vue';

    export default {
        components: {
            AddContact,
            EditContact
        },
        data() {
            return {
                contacts: [],
                showAddContact: false,
                editingContactId: null
            };
        },
        mounted() {
            this.fetchContacts();
        },
        methods: {
            toggleAddContact() {
                this.showAddContact = !this.showAddContact;
            },
            fetchContacts() {
                fetch('https://localhost:7224/api/contacts')
                    .then(response => response.json())
                    .then(data => {
                        this.contacts = data.contacts;
                    });
            },
            editContact(id) {
                this.editingContactId = id;
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

<style scoped>
    button {
        margin-left: 5px;
    }
</style>

