var arrayOfNumbers = [805, 21, 6, 5, -734, 65, 4, 26, 7],
    i,
    j,
    len = arrayOfNumbers.length,
    temp;

for (i = 0; i < len; i += 1) {
    for (j = i; j < len; j += 1) {
        if (arrayOfNumbers[i] >= arrayOfNumbers[j]) {
            temp = arrayOfNumbers[j];
            arrayOfNumbers[j] = arrayOfNumbers[i];
            arrayOfNumbers[i] = temp;
        }
    }
}

console.log(arrayOfNumbers);
