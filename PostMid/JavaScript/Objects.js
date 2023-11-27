var obj1 = new Object(); //Explicit object creation
var obj2 = {}; //implicit object creation

obj1["ID"] = 1;
obj1.Name = "Ali";
obj1.ContactNumber = "0900-785601";
obj1["Age"] = 23;

var json = JSON.stringify(obj1);
console.log(json);

obj2["ID"] = 2;
obj2.Name = "Hamza";
obj2.ContactNumber = "0900-785601";
obj2["Age"] = 36;

var json2 = JSON.stringify(obj2);
console.log(json2);
