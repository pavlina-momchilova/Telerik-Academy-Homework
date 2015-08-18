/*Write a function that finds the youngest person in a 
given array of people and prints his/hers full name
Each person has properties firstname, lastname and age.*/

var people = [
    { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'Pesho', lastname: 'Kostov', age: 11 },
    { firstname: 'Dancho', lastname: 'Ivanov', age: 8 },
    { firstname: 'Penka', lastname: 'Hristova', age: 24 }
];
function yangestPerson(arr) {
    arr = arr || [];
    var person = arr[0];
    for (var human in arr) {
        if (arr[human].age < person.age) {
            person = arr[human];
        }
    }
    return person.firstname + ' ' + person.lastname + ' ' + person.age;
}

if (yangestPerson(people) === undefined) {
    console.log('The array is empty or didn\'t have property age');
}
else {
    console.log(('The yangest person is: ' + yangestPerson(people)));
}