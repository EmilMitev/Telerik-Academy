var a,
    b,
    c,
    D,
    x1,
    x2;

a = 2;
b = 5;
c = -3;
D = b * b - 4 * a * c;
if (D > 0) {
    x1 = (-b - Math.sqrt(D)) / (2 * a);
    x2 = (-b + Math.sqrt(D)) / (2 * a);
    console.log('x1 = ' + x1 + '; x2 = ' + x2);
} else if (D === 0) {
    x1 = x2 = -b / (2 * a);
    console.log('x1 = x2 = ' + x1);
} else {
    console.log('No real roots');
}

a = -1;
b = 3;
c = 0;
D = b * b - 4 * a * c;
if (D > 0) {
    x1 = (-b - Math.sqrt(D)) / (2 * a);
    x2 = (-b + Math.sqrt(D)) / (2 * a);
    console.log('x1 = ' + x1 + '; x2 = ' + x2);
} else if (D === 0) {
    x1 = x2 = -b / (2 * a);
    console.log('x1 = x2 = ' + x1);
} else {
    console.log('No real roots');
}

a = -0.5;
b = 4;
c = -8;
D = b * b - 4 * a * c;
if (D > 0) {
    x1 = (-b - Math.sqrt(D)) / (2 * a);
    x2 = (-b + Math.sqrt(D)) / (2 * a);
    console.log('x1 = ' + x1 + '; x2 = ' + x2);
} else if (D === 0) {
    x1 = x2 = -b / (2 * a);
    console.log('x1 = x2 = ' + x1);
} else {
    console.log('No real roots');
}

a = 5;
b = 2;
c = 8;
D = b * b - 4 * a * c;
if (D > 0) {
    x1 = (-b - Math.sqrt(D)) / (2 * a);
    x2 = (-b + Math.sqrt(D)) / (2 * a);
    console.log('x1 = ' + x1 + '; x2 = ' + x2);
} else if (D === 0) {
    x1 = x2 = -b / (2 * a);
    console.log('x1 = x2 = ' + x1);
} else {
    console.log('No real roots');
}

