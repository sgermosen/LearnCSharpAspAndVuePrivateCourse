import Vue from 'vue';
import ContactList from './components/ContactList.vue';
import AddContact from './components/AddContact.vue';

new Vue({
    el: '#app',
    components: {
        ContactList,
        AddContact
    },
    template: `
        <div>
            <add-contact></add-contact>
            <contact-list></contact-list>
        </div>
    `
});
