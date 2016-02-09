var x,
    y,
    dx,
    dy,
    radius = 5,
    dr;

dr = Math.pow(radius, 2);

x = -1;
y = 1;
dx = Math.pow(x, 2);
dy = Math.pow(y, 2);
pointIn = (dx + dy) <= dr;
console.log('x: ' + x + ' y: ' + y + ' inside: ' + pointIn);

x = -5;
y = 0;
dx = Math.pow(x, 2);
dy = Math.pow(y, 2);
pointIn = (dx + dy) <= dr;
console.log('x: ' + x + ' y: ' + y + ' inside: ' + pointIn);

x = -4;
y = 5;
dx = Math.pow(x, 2);
dy = Math.pow(y, 2);
pointIn = (dx + dy) <= dr;
console.log('x: ' + x + ' y: ' + y + ' inside: ' + pointIn);

x = 1.5;
y = -3;
dx = Math.pow(x, 2);
dy = Math.pow(y, 2);
pointIn = (dx + dy) <= dr;
console.log('x: ' + x + ' y: ' + y + ' inside: ' + pointIn);

x = -4;
y = -3.5;
dx = Math.pow(x, 2);
dy = Math.pow(y, 2);
pointIn = (dx + dy) <= dr;
console.log('x: ' + x + ' y: ' + y + ' inside: ' + pointIn);

x = 100;
y = -30;
dx = Math.pow(x, 2);
dy = Math.pow(y, 2);
pointIn = (dx + dy) <= dr;
console.log('x: ' + x + ' y: ' + y + ' inside: ' + pointIn);

x = 0;
y = 0;
dx = Math.pow(x, 2);
dy = Math.pow(y, 2);
pointIn = (dx + dy) <= dr;
console.log('x: ' + x + ' y: ' + y + ' inside: ' + pointIn);

x = 0.2;
y = -0.8;
dx = Math.pow(x, 2);
dy = Math.pow(y, 2);
pointIn = (dx + dy) <= dr;
console.log('x: ' + x + ' y: ' + y + ' inside: ' + pointIn);

x = 0.9;
y = -4.93;
dx = Math.pow(x, 2);
dy = Math.pow(y, 2);
pointIn = (dx + dy) <= dr;
console.log('x: ' + x + ' y: ' + y + ' inside: ' + pointIn);

x = 2;
y = 2.655;
dx = Math.pow(x, 2);
dy = Math.pow(y, 2);
pointIn = (dx + dy) <= dr;
console.log('x: ' + x + ' y: ' + y + ' inside: ' + pointIn);