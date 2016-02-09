var p = 3;
n = 5;
bit = (n & (1 << p)) >> p;
console.log('Third bit is: ' + bit);

n = 8;
bit = (n & (1 << p)) >> p;
console.log('Third bit is: ' + bit);

n = 0;
bit = (n & (1 << p)) >> p;
console.log('Third bit is: ' + bit);

n = 15;
bit = (n & (1 << p)) >> p;
console.log('Third bit is: ' + bit);

n = 5343;
bit = (n & (1 << p)) >> p;
console.log('Third bit is: ' + bit);

n = 62241;
bit = (n & (1 << p)) >> p;
console.log('Third bit is: ' + bit);