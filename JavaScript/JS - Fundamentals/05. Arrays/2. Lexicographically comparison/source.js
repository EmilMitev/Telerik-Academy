var arr1 = ['a','s','d','f','g','y','t','r','e','w'],
	arr2 = ['a','s','d','e','r','t','g','h','j','u'],
	len, i;

len = arr1.length;

for (i = 0; i <len; i+=1) {
	console.log(arr1[i] + ' > ' + arr2[i] + ' - ' + (arr1[i] > arr2[i]));
}