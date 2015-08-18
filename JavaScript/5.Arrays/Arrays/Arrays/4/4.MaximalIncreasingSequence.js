/*Write a script that finds
the maximal increasing sequence in an array.
 */
var arr = [3, 2, 3, 4, 2, 2, 4],
    countInc = 1, countMax = 0, maxInc, inc = arr[0], i,
    len = arr.length;

for (i = 0; i < len; i++) {
    if (arr[i] < arr[i+1]) {
        inc += ', ' + arr[i+1];
        countInc += 1;
    }
    else {
        if (countMax < countInc) {
            countMax = countInc;
            maxInc = inc;
        }
        inc = arr[i+1];
        countInc = 1;
        temp = arr[i+1];
    }
}
console.log(maxInc);