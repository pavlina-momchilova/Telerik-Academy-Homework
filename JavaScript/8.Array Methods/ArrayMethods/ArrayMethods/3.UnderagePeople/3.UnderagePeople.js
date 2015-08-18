/*
 * Write a function that prints all underaged persons of an array of person
Use Array#filter and Array#forEach
Use only array methods and no regular loops (for, while)
 */
var person = [
{ firstname: 'Gosho', lastname: 'Petrakiev', age: 22 },
{ firstname: 'Krasimir', lastname: 'Ivanov', age: 15 },
{ firstname: 'Petar', lastname: 'Konzolov', age: 17 },
{ firstname: 'Cvetan', lastname: 'Dimov', age: 27 },
{ firstname: 'Aleksandar', lastname: 'Petrov', age: 13 }
];

var underagePerson = person.filter(function (item) {
    return item.age < 18;})
    .forEach(function (item, index) {
        console.log(item.firstname + ' age: ' + item.age);
    })