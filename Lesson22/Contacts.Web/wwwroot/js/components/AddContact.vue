<!--<template>
    <div>
        <h1>Add Contact</h1>
        <form @submit.prevent="addContact">
            <div>
                <label for="firstName">First Name:</label>
                <input type="text" v-model="firstName" />
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
                <label for="phoneNumber">Phone Number:</label>
                <input type="text" v-model="phoneNumber" />
            </div>
            <button type="submit">Add Contact</button>
        </form>
    </div>
</template>

<script>
    export default {
        data() {
            return {
                firstName: '',
                lastName: '',
                email: '',
                phoneNumber: ''
            };
        },
        methods: {
            addContact() {
                let newContact = {
                    name: this.firstName,
                    lastName: this.lastName,
                    email: this.email,
                    phone: this.phoneNumber
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
                        console.log('Contact added:', data);
                        this.firstName = '';
                        this.lastName = '';
                        this.email = '';
                        this.phoneNumber = '';
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
    <div>
        <h2>Add Contact</h2>
        <form @submit.prevent="addContact" class="mb-3">
            <div class="form-group">
                <label for="firstName">First Name:</label>
                <input type="text" class="form-control" v-model="firstName" />
            </div>
            <div class="form-group">
                <label for="lastName">Last Name:</label>
                <input type="text" class="form-control" v-model="lastName" />
            </div>
            <div class="form-group">
                <label for="email">Email:</label>
                <input type="email" class="form-control" v-model="email" />
            </div>
            <div class="form-group">
                <label for="phoneNumber">Phone Number:</label>
                <input type="text" class="form-control" v-model="phoneNumber" />
            </div>
            <button type="submit" class="btn btn-success">Add Contact</button>
        </form>
    </div>
</template>

<script>
    export default {
        data() {
            return {
                firstName: '',
                lastName: '',
                email: '',
                phoneNumber: ''
            };
        },
        methods: {
            addContact() {
                let newContact = {
                    name: this.firstName,
                    lastName: this.lastName,
                    email: this.email,
                    phone: this.phoneNumber
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
                        console.log('Contact added:', data);
                        this.$emit('contact-added');
                        this.firstName = '';
                        this.lastName = '';
                        this.email = '';
                        this.phoneNumber = '';
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
