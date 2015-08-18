/*
 * Write a function that finds the youngest male person in a given array of people and prints his full name
Use only array methods and no regular loops (for, while)
Use Array#find
 */
if (!Array.prototype.find) {
    Array.prototype.find = function (callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    }
}

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

var yangestMale = person.filter(function (item) {
    return item.gender === 'male';
})
var yangest = yangestMale[0].age;
yangestMale.forEach(function (item) {
    if (yangest > item.age) {
        yangest = item.age;
    }
});
yangestMale = yangestMale.find(function (item) {
    return item.age === yangest;
});
console.log(yangestMale);