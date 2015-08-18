/*Write a function that returns the index of the
first element in array that is larger than its neighbours
or -1, if there’s no such element.
Use the function from the previous exercise.*/

function biggerThenTwoNeighbour() {
    var i, position, arr = [2, 5, 6, 9, 8, 8, 7, 2, 6, 3, 0, 1, 52, 2], len = arr.length, flag = false;
    console.log("The array is: [2, 5, 6, 9, 8, 8, 7, 2, 6, 3, 0, 1, 52, 2]");
    for (i = 0; i < len; i += 1) {
            if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1]) {
                flag = true;
                position = i;
                break;
            }
    }
        if (flag) {
            console.log("The first index of an element that is bigger than it's two neighbors is :"+position);
        }
        else {
            console.log("There is no such element!");
        }
}

biggerThenTwoNeighbour();