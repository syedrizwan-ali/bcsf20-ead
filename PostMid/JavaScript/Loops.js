var arr5 = [10, 20, 30];
arr5["myProp"] = "this is my prop";
arr5.Age = 27;

console.log("FOR LOOP");
for(var i = 0; i < arr5.length; i++)
{
    console.log(arr5[i]);
}

console.log("WHILE LOOP");
var j = 0;
while (j < arr5.length)
{
    console.log(arr5[j]);
    j++;
}

console.log("DO WHILE LOOP");
var k = 0;
do
{
    console.log(arr5[k]);
    k++;
} while(k < arr5.length);

console.log("FOR IN LOOP");
for(var key in arr5)
{
    console.log("key:" + key + ", value:" + arr5[key]);
}
