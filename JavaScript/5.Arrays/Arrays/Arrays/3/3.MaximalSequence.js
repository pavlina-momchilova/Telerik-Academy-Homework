/*Write a script that finds the maximal 
 sequence of equal elements in an array.*/

var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
    countSeq=1,countMax=0, maxSeq, seq=arr[0], i, len = arr.length, temp=arr[0];

for (i = 1; i < len; i++) {
    if (temp === arr[i]) {
        seq += ', ' + arr[i];
        countSeq+=1;
    }
    else {
        if (countMax < countSeq) {
            countMax = countSeq;
            maxSeq = seq;
        }
        seq = arr[i];
        countSeq = 1;
        temp = arr[i];
    }
}
console.log(maxSeq);