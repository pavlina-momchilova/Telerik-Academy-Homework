/*Write a function that removes all elements with a given value.
Attach it to the array type.
Read about prototype and how to attach methods.*/
var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

Array.prototype.remove = function (element) {
    var len = this.length;
    for (var i = 0; i < len; i++) {
        if (this[i] === element) {
            this.splice(i, 1);
            i -= 1;
        }
    }
    return this;
}
arr.remove(1);
console.log(arr.join(', '));