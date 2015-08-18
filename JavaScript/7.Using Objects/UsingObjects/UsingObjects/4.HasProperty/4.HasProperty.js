/*Write a function that checks if a given object contains a given property.*/
var Person = {
    name: "Pesho",
    age: 23,
    country: "Bulgaria"
};

function hasProperty(obj, prop) {
    obj = obj || {};
    prop = prop || '';
    for (var prop1 in obj) {
        var flag = false;
        if (prop1 === prop) {
            flag = true;
            break;
        }
    }
    return flag;
}


var hasProp = hasProperty(Person, 'country');

if (hasProp) {
    console.log('the object contains this property ');
}
else {
    console.log('the object does not have this property ');
}
