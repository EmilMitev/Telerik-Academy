var N = 100;

for (var i = 0; i <= N; i += 1) {
    if (!(!(i % 3) && !(i % 7))) {
        console.log(i);
    }
}
