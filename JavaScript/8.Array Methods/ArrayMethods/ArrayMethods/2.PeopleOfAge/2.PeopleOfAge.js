/*
 * Write a function that checks if an array of person contains only people of age (with age 18 or greater)
Use only array methods and no regular loops (for, while)
 */

var person = [
{ firstname: 'Gosho', lastname: 'Petrakiev', age: 22 },
{ firstname: 'Krasimir', lastname: 'Ivanov', age: 25 },
{ firstname: 'Petar', lastname: 'Konzolov', age: 18 },
{ firstname: 'Cvetan', lastname: 'Dimov', age: 27 },
{ firstname: 'Aleksandar', lastname: 'Petrov', age: 23 }
];
var person2 = [
{ firstname: 'Gosho', lastname: 'Petrakiev', age: 22 },
{ firstname: 'Krasimir', lastname: 'Ivanov', age: 12 },
{ firstname: 'Petar', lastname: 'Konzolov', age: 18 },
{ firstname: 'Cvetan', lastname: 'Dimov', age: 17 },
{ firstname: 'Aleksandar', lastname: 'Petrov', age: 21 }
];

function isGreaterOrEqualTo18(item) {
    return !!(item.age >= 18);
}
console.log('The ages of the peopele 22,25,18,27,23');
console.log(person.every(isGreaterOrEqualTo18));
console.log('The ages of the peopele 22,12,18,17,21');
console.log(person2.every(isGreaterOrEqualTo18));