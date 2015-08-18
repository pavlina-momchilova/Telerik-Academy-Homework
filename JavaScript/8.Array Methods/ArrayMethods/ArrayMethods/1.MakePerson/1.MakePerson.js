/*
 * Write a function for creating persons.
Each person must have firstname, lastname, age and gender (true is female, false is male)
Generate an array with ten person with different names, ages and genders
 */

if (!Array.prototype.fill) {
    Array.prototype.fill = function (callback) {
        var i, len = this.length;
        for (var i = 0; i < len; i+=1) {
            this[i] = arguments[0];
        }
        return this;
    }
}

var person = [], n = 10;
person[n - 1] = undefined;
function getRandomDigit() { return (Math.random() * 10) | 0; }
function getFirstLastAge(person) {
    var firstNames = ['Peter', 'Pencho', 'Gosho', 'Ivan', 'Stamat', 'Ivailo', 'Marin', 'Cvetan', 'Kircho', 'Kiril'];
    var lastNames = ['Ivanov', 'Petrov', 'Kirilov', 'Georgiev', 'Panov', 'Iordanov', 'Stefanov', 'Ilianev', 'Marinov', 'Zahariev','Cvetelinov'];
    var ages = [21, 54, 69, 74, 12, 36, 54, 18, 10, 57];
    var gender =[true,false];
    var human = {
        firstname: firstNames[person],
        lastname: lastNames[person],
        age: ages[person],
        gender : gender[person%2]
    };
    return human;
}

var humans = person.fill(0)
    .map(getRandomDigit)
    .map(getFirstLastAge);

function objToString(obj)
{
    return 'firstname: ' + obj.firstname + ' lastname: ' + obj.lastname + ' age: ' + obj.age + ' gender: ' + obj.gender;
}

for (var i = 0; i < 10; i++) {
    console.log(objToString(humans[i]));
}
