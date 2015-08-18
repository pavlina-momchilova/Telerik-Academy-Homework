/*
 Sorting an array means to arrange its elements in increasing order.
Write a script to sort an array.
Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest 
from the rest, move it at the second position, etc. 
 */

var k, j, i, min, index, arr = [1, 3, 5, 2, 8, 6, 7, 4, 9], len = arr.length;

for (i = 0; i < len; i++) {
    min = arr[i];
    index = i;
    for (j = i; j < len; j++) {
        if (min > arr[j]) {
            min = arr[j];
            index=j;
        }
    }
    arr.splice(index, 1);
    arr.splice(i,0,min);
}
for (k = 0; k < len; k++) {
    console.log(arr[k]);
}