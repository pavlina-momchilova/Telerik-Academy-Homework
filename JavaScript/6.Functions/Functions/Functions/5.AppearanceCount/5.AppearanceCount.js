/*Write a function that counts how many times given number appears in given array.
Write a test function to check if the function is working correctly.*/

function apearingNum(arr, num) {
    var i, len = arr.length, count = 0;
    for (i = 0; i < len; i++) {
        if (arr[i] === num) {
            count += 1;
        }
    }
    if (count === 1) {
        console.log('The number ' + num + ' apears ' + count + ' time');
    }
    else {
        console.log('The number ' + num + ' apears ' + count + ' times');
    }
}

function testApearingNum(testNumber) {
    testNumber = testNumber || 0;
    switch (testNumber) {
        case 0: apearingNum([5, 2, 3, 6, 6, 9, 2, 4, 6, 3, 2], 6);
            break;
        case 1: apearingNum([5, 2, 3, 6, 7, 9, 5, 5, 6, 3, 2], 5);
            break;
        case 2: apearingNum([2, 2, 3, 6, 7, 9, 5, 5, 6, 3, 2], 2);
            break;
        case 3: apearingNum([3, 2, 4, 6, 4, 9, 4, 50, 6, 4, 2], 4);
            break;
        case 4: apearingNum([1, 2, 3, 4, 5, 6, 7, 8, 9], 9);
            break;
        default: console.log("wrong input!");
            break;

    }
}
console.log("Test 0:");
console.log("The array is: [5, 2, 3, 6, 6, 9, 2, 4, 6, 3, 2]");
testApearingNum(0);
console.log("Test 1:");
console.log("The array is: [5, 2, 3, 6, 7, 9, 5, 5, 6, 3, 2]");
testApearingNum(1);
console.log("Test 2:");
console.log("The array is: [2, 2, 3, 6, 7, 9, 5, 5, 6, 3, 2]");
testApearingNum(2);
console.log("Test 3:");
console.log("The array is: [3, 2, 4, 6, 4, 9, 4, 50, 6, 4, 2]");
testApearingNum(3);
console.log("Test 4:");
console.log("The array is: [1, 2, 3, 4, 5, 6, 7, 8, 9]");
testApearingNum(4);