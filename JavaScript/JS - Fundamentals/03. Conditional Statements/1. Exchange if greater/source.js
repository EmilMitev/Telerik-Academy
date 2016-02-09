var a,
    b;

a = 5;
b = 2;

if (a > b) {
    a = a + b;
    b = a - b;
    a = a - b;
    console.log(a + ' ' + b);
} else {
	console.log(a + ' ' + b);
}

a = 3;
b = 4;
if (a > b) {
    a = a + b;
    b = a - b;
    a = a - b;
    console.log(a + ' ' + b);
} else {
	console.log(a + ' ' + b);
}

a = 5.5;
b = 4.5;
if (a > b) {
    a = a + b;
    b = a - b;
    a = a - b;
    console.log(a + ' ' + b);
} else {
	console.log(a + ' ' + b);
}
