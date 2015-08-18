/*
 * Write a function that checks if the element at given position
 *  in given array of integers 
 * is bigger than its two neighbours (when such exist).
 */

function biggerThenTwoNeighbour(position) {
    var i, arr = [2, 5, 6, 9, 8, 8, 7, 2, 6, 3, 0, 1, 52, 2], len = arr.length,flag=false,bigger=false;
    console.log("The array is: [2, 5, 6, 9, 8, 8, 7, 2, 6, 3, 0, 1, 52, 2]");
    for (i = 0; i < len; i += 1) {
        if (i === position) {
            if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1]) {
                flag = true;
                bigger = true;
            }
            else {
                flag = true;
                
            }
        }
    }
    if (flag == false) {
        console.log("There is no such position");
    }
    else {
        if (bigger) {
            console.log("The element " + arr[position] + " is bigger than it's two neighbours: " + arr[position - 1] + ", " + arr[position + 1]);
        }
        else {
            console.log("The element " + arr[position] + " is not bigger than it's two neighbours: " + arr[position - 1] + ", " + arr[position + 1]);
        }
    }
}

biggerThenTwoNeighbour(1);
biggerThenTwoNeighbour(100);
biggerThenTwoNeighbour(12);