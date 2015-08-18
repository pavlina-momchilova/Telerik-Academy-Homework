var smallestDoc = 'z';
var largestDoc = 'a';
for (var property in document) {
    if (smallestDoc > property) {
        smallestDoc = property;
    }
    if (largestDoc < property) {
        largestDoc = property;
    }
}
console.log('The smallest property in document: ' + smallestDoc);
console.log('The biggest property in document: ' + largestDoc);

var smallestWin = 'z';
var largestWin = 'a';
for (var property in window) {
    if (smallestWin > property) {
        smallestWin = property;
    }
    if (largestWin < property) {
        largestWin = property;
    }
}
console.log('The smallest property in window: ' + smallestWin);
console.log('The biggest property in window: ' + largestWin);

var smallestNav = 'z';
var largestNav = 'a';
for (var property in navigator) {
    if (smallestNav > property) {
        smallestNav = property;
    }
    if (largestNav < property) {
        largestNav = property;
    }
}
console.log('The smallest property in window: ' + smallestNav);
console.log('The biggest property in window: ' + largestNav);