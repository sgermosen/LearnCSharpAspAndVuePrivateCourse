var name = "juan";
var name2 = 'pedro';

let lastName = "Santiago";
let age = 15;
let currentYear = 2024;
let bornYear = "1988";

age = currentYear + bornYear ; // '20241988'  

const thisIsConstant = "0";

//let functionResult = sayHello(name, lastName);

//console.log(functionResult);
//alert(functionResult   );
const content = paragrahp11.querySelector('#content');
//document.getElementById('paragrahp11').innerHTML = functionResult;
document.getElementById('submit').addEventListener('click', function(){
  //  alert ('Hello   from        ');
   // sayHello('name', 'lastName');
const paragrahp11 = document.getElementById('paragrahp11');

   paragrahp11.innerHTML = 'Content';
});
 //document.getElementById('submit2').addEventListener('click', sayHello('name', 'lastName'));

 document.getElementById('contactForm').addEventListener('submit', function (event)
 {
event.preventDefault();
let name = document.getElementById('name').value;
alert('send message to ' + name);
 }
);


function sayHello(message, message2)
{
    //return 'Hello ' + message + ' ' + message2; 
    alert (`Hello ${message} and ${message2}`);
     return `Hello ${message} and ${message2}`;
}
