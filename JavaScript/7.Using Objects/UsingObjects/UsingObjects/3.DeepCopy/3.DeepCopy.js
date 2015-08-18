/*Write a function that makes a deep copy of an object.
The function should work for both primitive and reference types.*/ 
var Student = {
        name: "Peter",
        age: "12",
        marks: {
            subject: 'Math',
            mark:6
        }
}

function deepCopy(obj) {
    if (obj === null || typeof (obj) !== 'object') {
        return obj;
    }
    var temp = obj.constructor(), prop;
    for (prop in  obj) {
        temp[prop] = deepCopy(obj[prop]);
    }
    return temp;
}

var copyngStudent = deepCopy(Student);

console.log('Objects before copy: name: ' + Student.name + ' age: ' + Student.age + ' subject: ' + Student.marks.subject + ' mark: ' + Student.marks.mark);
console.log('Objects after copy: name: ' + copyngStudent.name + ' age: ' + copyngStudent.age + ' subject: ' + copyngStudent.marks.subject + ' mark: ' + copyngStudent.marks.mark);
copyngStudent.name = "Sasho";
copyngStudent.age = "15";
copyngStudent.marks.subject = "English";
copyngStudent.marks.mark = "3";
console.log('Object after change copying object: name: ' + copyngStudent.name + ' age: ' + copyngStudent.age + ' subject: ' + copyngStudent.marks.subject + ' mark: ' + copyngStudent.marks.mark);