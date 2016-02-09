var arrayOfNumbers = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    count = 0,
    mostFrequentNumber = 0,
    i,
    j,
    tempCount,
    len = arrayOfNumbers.length;

for (i = 0; i < len; i += 1) {
    tempCount = 0;
    for (j = 0; j < len; j += 1) {
        if (arrayOfNumbers[i] == arrayOfNumbers[j]) {
            ++tempCount;
        }
    }
    if (tempCount >= count) {
        count = tempCount;
        mostFrequentNumber = arrayOfNumbers[i];
    }
}
console.log('Result is: ' + mostFrequentNumber + ' (' + count + ' times)');
