var number,
    sqrtNumber,
    i,
    j,
    count;

for (i = 0; i <= 100; i+=1) {
    number = i;
    count = 1;
    sqrtNumber = Math.sqrt(number);
    for (j = 1; j <= sqrtNumber; j+=1) {
        if (number === 0 || number == 1) {
            continue;
        } else {
            if (number % j === 0) {
                count++;
            }
        }
    }

    if (count === 2) {
        console.log('The number: ' + i + '; Prime? - True');
    } else {
        console.log('The number: ' + i + '; Prime? - false');
    }
}
