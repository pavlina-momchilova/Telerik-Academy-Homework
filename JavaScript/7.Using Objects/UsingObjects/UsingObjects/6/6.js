/*Write a function that groups an array of people by age, first or last name.
The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
Use function overloading (i.e. just one function)*/

var people = [
    { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'Pesho', lastname: 'Kostov', age: 11 },
    { firstname: 'Dancho', lastname: 'Ivanov', age: 8 },
    { firstname: 'Penka', lastname: 'Hristova', age: 24 }
];

function group(arr, prop) {
    var firstname, lastname, age;
    switch (prop) {
        case 'firstname':
            var people = [];
            for (var human in arr) {
                people.push(arr[human].firstname);
            }
            return firstname = {
                groupName: 'firstname',
                arrPeople: people.join(', ')
            };
            break;
        case 'lastname':
            var people = [];
            for (var human in arr) {
                people.push(arr[human].lastname);
            }
            return lastname = {
                groupName: 'lastname',
                arrPeople: people.join(', ')
            };
            break;
        case 'age':
            var people = [];
            for (var human in arr) {
                people.push(arr[human].age);
            }
            return age = {
                groupName: 'age',
                arrPeople: people.join(', ')
            };
            break;
    }
}
var groupedByFname = group(people, 'firstname');
var groupedByLname = group(people, 'lastname');
var groupedByAge = group(people, 'age');

console.log('grouped by first name:');
console.log('Group Name: ' + groupedByFname.groupName + ' first name arr: ' + groupedByFname.arrPeople);
console.log('grouped by last name:');
console.log('Group Name: ' + groupedByLname.groupName + ' last name arr: ' + groupedByLname.arrPeople);
console.log('grouped by age:');
console.log('Group Name: ' + groupedByAge.groupName + ' age arr: ' + groupedByAge.arrPeople);