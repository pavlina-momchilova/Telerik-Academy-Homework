/*
 * Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
Use Array#reduce
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

person.sort(function (p1, p2) {
    return p1.firstname > p2.firstname;
});
var result = {};
/*
person.forEach(function (item) {
    var firstLatter = item.firstname.substring(0, 1);
    if (result.hasOwnProperty(item.firstname.substring(0, 1)) === false) {
        var arr = [];
        person.forEach(function(item1){
            if(item1.firstname.substring(0,1)===item.firstname.substring(0,1)){
                arr.push(item1);
            }
        })
        result[item.firstname.substring(0, 1)] = arr;
    }
});
console.log(result);*/
function group() {
    person.forEach(function (item) {
        var firstLatter = item.firstname.substring(0, 1);
        if (result.hasOwnProperty(item.firstname.substring(0, 1)) === false) {
            var arr = person.reduce(function flatten(arr, item1) {
                var arr = [];
                person.forEach(function (item2) {
                    if (item2.firstname.substring(0, 1) === item.firstname.substring(0, 1)) {
                        arr.push(item2);
                    }
                });
                return arr;
            }, []);
            result[item.firstname.substring(0, 1)] = arr;
        }
    });
    return result;
}

console.log(group());