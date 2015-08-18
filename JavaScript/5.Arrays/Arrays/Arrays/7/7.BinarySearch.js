/*
 Write a script that finds the index of given element in
 a sorted array of
 integers by using the binary search algorithm.
 */
var i, arr = [1, 4, 10, 12, 15, 20, 22], len = arr.length,
    left = 0, right = len - 1,
    middle, searchNum = 4;
    console.log('The array is arr=[' + arr.join(', ') + ']');
    for (i = left; i <= right; i++) {
        if (left === right) {
            console.log('The number is not in the array');
            break;
        }
        middle = Math.floor((left + right) / 2);
        if (arr[middle] === searchNum) {
            console.log('The number ' + searchNum + ' is found in index = ' + middle);
            break;
        }
        else if (arr[middle] > searchNum) {
            right = middle - 1;
            if (left === right) {
                if (arr[left] === searchNum) {
                    console.log('The number ' + searchNum + ' is found in index = ' + left);
                    break;
                }
                else {
                    console.log('The number is not in the array');
                    break;
                }
            }
        }
        else if (arr[middle] < searchNum) {
            left = middle + 1;
            if (left === right) {
                if (arr[left] === searchNum) {
                    console.log('The number '+searchNum+' is found in index = ' + left);
                    break;
                }
                else {
                    console.log('The number is not in the array');
                    break;
                }
            }
        }
    }
