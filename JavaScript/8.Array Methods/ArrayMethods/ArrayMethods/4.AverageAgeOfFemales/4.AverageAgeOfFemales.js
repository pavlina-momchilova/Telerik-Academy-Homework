/*
 * Write a function that calculates the average age of all females, extracted from an array of persons
Use Array#filter
Use only array methods and no regular loops (for, while)
 */
var person = [
{ firstname: 'Gosho', lastname: 'Petrakiev', age: 22, gender: 'male' },
{ firstname: 'Krasimir', lastname: 'Ivanov', age: 15, gender: 'male' },
{ firstname: 'Petq', lastname: 'Karadjova', age: 24, gender: 'female' },
{ firstname: 'Cvetelina', lastname: 'Manolova', age: 19, gender: 'female' },
{ firstname: 'Katerina', lastname: 'Aleksieva', age: 28, gender: 'female' },
{ firstname: 'Petar', lastname: 'Konzolov', age: 17, gender: 'male' },
{ firstname: 'Cvetan', lastname: 'Dimov', age: 27, gender: 'male' },
{ firstname: 'Aleksandar', lastname: 'Petrov', age: 13, gender: 'male' }
];

var females = person.filter(function (item) {
    return item.gender === 'female';
});
var len = females.length;
females=females.reduce(function (avg, item) {
    return (avg + item.age);
}, 0);
console.log(Math.floor(females/len));