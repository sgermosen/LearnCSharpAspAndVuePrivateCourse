<template>
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
</style>
