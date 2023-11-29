//Datatypes in javascript

//implicitly
var a = 0; //Number
var b = true; //Boolean
var c = "Ali"; //string
var d = 'c'; //character
var e = '1996-11-27 20:00:00'; // Date
var f = null; //Null
var g = undefined; //Undefined

//explicitly
var aa = new Number(); //Default value: 0
var bb = new Boolean(); //Default value: false
var cc = new String(); //Default value: empty string
var dd = new Date(); //Default value: browser current date and time

console.log('implicit types assignment');
console.log(a);
console.log(b);
console.log(c);
console.log(d);
console.log(e);
console.log(f);
console.log(g);

console.log('explicit types assignment');
console.log(aa);
console.log(bb);
console.log(cc);
console.log(dd);

var ee = new Date(e);
console.log(ee);

////////////////////////

var num = new Number("23400");
console.log(num);

var num01 = new Number("23400a"); //will return NaN

var num02 = parseInt("23401a");
console.log(num02);

var num03 = new Number("3.5");
console.log(num03);

var num04 = new Number("3.5.1");

var num05 = parseFloat("356.50123612361.1123132");
console.log(num05);