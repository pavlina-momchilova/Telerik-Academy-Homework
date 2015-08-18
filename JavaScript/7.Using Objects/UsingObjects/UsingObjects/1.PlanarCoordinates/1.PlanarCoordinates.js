function Points(x, y) {
    this.x = x;
    this.y = y;
}

function Lines(P1, P2) {
    this.P1 = P1;
    this.P2 = P2;
}

function distance(P1,P2) {
    var dist = Math.sqrt((P1.x - P2.x) * (P1.x - P2.x) + (P1.y - P2.y) * (P1.y - P2.y));
    return dist;
}

var Point1 = new Points(5, 6);
var Point2 = new Points(3, 4);

var Point3 = new Points(7, 2);
var Point4 = new Points(8, 1);

var Point5 = new Points(7, 4);
var Point6 = new Points(7, 7);



console.log(distance(Point1, Point2));

var Line1 = new Lines(Point1, Point2);
var Line2 = new Lines(Point3, Point4);
var Line3 = new Lines(Point5, Point6);

function formATriangle(L1, L2, L3) {
    if ((distance(L1.P1, L1.P2) + distance(L2.P1, L2.P2)) > distance(L3.P1, L3.P2) && (distance(L2.P1, L2.P2) + distance(L3.P1, L3.P2)) > distance(L1.P1, L1.P2) && (distance(L1.P1, L1.P2) + distance(L3.P1, L3.P2)) > distance(L2.P1, L2.P2)) {
        console.log('The lines can form a triangle!');
    }
    else {
        console.log('The lines can\'t form a triangle!');
    }
}


formATriangle(Line1, Line2, Line3);