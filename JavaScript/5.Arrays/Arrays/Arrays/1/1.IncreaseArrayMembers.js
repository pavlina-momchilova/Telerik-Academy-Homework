﻿/*Write a script that allocates array of 20 
integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.*/
var i, arr = new Array(20), len = arr.length;

for (i = 0; i < len; i+=1) {
    arr[i] = i * 5;
}
for (i = 0; i < len; i+=1) {
    console.log(arr[i]);
}