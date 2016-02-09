var result;

console.log('Third digit 7?');

result = Math.floor((5 / 100) % 10) === 7;
console.log('      5 - ' + result);

result = Math.floor((701 / 100) % 10) === 7;
console.log('    701 - ' + result);

result = Math.floor((1732 / 100) % 10) === 7;
console.log('   1732 - ' + result);

result = Math.floor((9703 / 100) % 10) === 7;
console.log('   9703 - ' + result);

result = Math.floor((877 / 100) % 10) === 7;
console.log('    877 - ' + result);

result = Math.floor((777877 / 100) % 10) === 7;
console.log(' 777877 - ' + result);

result = Math.floor((9999799 / 100) % 10) === 7;
console.log('9999799 - ' + result);
