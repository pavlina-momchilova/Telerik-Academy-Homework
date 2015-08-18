/*
 * Write a function that creates a HTML <ul> using a template for every HTML <li>.
The source of the list should be an array of elements.
Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
 */

var people = [{ name: 'Peter', age: 14 },
    { name: 'Stanislava', age: 42 },
    { name: 'Bobi', age: 34 },
    { name: 'Kiril', age: 62 },
    { name: 'Samuil', age: 18 },
    { name: 'Ivan', age: 24 }];

var tmpl = document.getElementById('list-item').innerHTML;


function generateList(people, tmpl) {
    var result = '<ul>', i, len = people.length,temp='';

    for (i = 0; i < len; i+=1) {
        result += '<li>';
        temp = tmpl.replace('-{name}-', people[i].name);
        temp = temp.replace('-{age}-', people[i].age);
        result += temp;
        temp = '';
        result += '</li>';
    }
    result += '</ul>';

    return result;
}

var peopleList = generateList(people, tmpl);

console.log(peopleList);