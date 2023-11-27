var arr1 = new Array();
var arr2 = [12, 23, 34, 45, 56];

console.log(arr2.toString());
console.log(arr2.length);

arr1[0] = 10;
arr1[2] = 20;

console.log(arr1.toString());

var arr3 = [];
arr3.push('Money');
arr3.push(2023);
arr3.push(new Date());
arr3.push(false);
arr3.push('c');

var val = arr3.pop();
console.log(val + ", length: " + arr3.length);

val = arr3.pop();
console.log(val + ", length: " + arr3.length);

val = arr3.pop();
console.log(val + ", length: " + arr3.length);

val = arr3.pop();
console.log(val + ", length: " + arr3.length);

val = arr3.pop();
console.log(val + ", length: " + arr3.length);


var arr5 = [10, 20, 30];
arr5["myProp"] = "this is my prop";
arr5.Age = 27;

console.log(arr5.toString());
console.log(arr5.myProp);
console.log(arr5["Age"]);