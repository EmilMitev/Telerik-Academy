function ReverseNumber(num) {
    var reverseNumber = '',
        number = num.toString(),
        len = number.length,
        i;

    for (i = len - 1; i >= 0; i -= 1) {
        reverseNumber += number[i];
    }
    return +reverseNumber;
}

console.log(ReverseNumber(652));
console.log(ReverseNumber(123.45));
