var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],

    end = 0,
    longest = 1,
    currentLongest = 1,
    i, len;

for (i = 0, len = arr.length; i < len - 1; i++) {

    if (arr[i] == arr[i + 1]) {
        end = i + 1;
        currentLongest++;
    } else {
        if (currentLongest > longest) {
            longest = currentLongest;
        }
        currentLongest = 1;
    }
}
if (currentLongest > longest) {
    longest = currentLongest;
}
console.log("Result is: ");
for (i = end - longest + 1; i <= end; i++) {
    if (i == end) {
        console.log(arr[i]);
    } else {
        console.log(arr[i] + ', ');
    }
}
