//import { createApp } from 'vue';
//import ContactList from './components/ContactList.vue';
//import AddContact from './components/AddContact.vue';

//createApp({
//    components: {
//        ContactList,
//        AddContact
//    },
//    template: `
//        <div>
//            <add-contact></add-contact>
//            <contact-list></contact-list>
//        </div>
//    `
//}).mount('#app');
import { createApp } from 'vue';
import ContactList from './components/ContactList.vue';

createApp(ContactList).mount('#app');

