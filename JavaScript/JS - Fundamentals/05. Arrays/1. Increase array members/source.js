var arr = [],
	len,i;

arr[20] = undefined;

for (i = 0, len = arr.length; i <len; i +=1) {
	arr[i] = i*5;
}

console.log(arr);