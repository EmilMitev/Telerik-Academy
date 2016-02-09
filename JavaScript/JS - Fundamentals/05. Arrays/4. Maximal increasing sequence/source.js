var arr = [3, 2, 3, 4, 2, 2, 4, 5, 6, 8, 9],
    len = arr.length,
    i,
    currentLongest = 1,
    longest = 1,
    end = 0;


for (i = 0; i < len - 1; i++) {

    if (arr[i] < arr[i + 1]) {
        end = i + 1;
        currentLongest += 1;
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
