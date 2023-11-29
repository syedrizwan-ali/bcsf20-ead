function Sum(a, b)
{
    return a + b;
}

function Foo(a , b)
{

}

var result = Sum(1, 2);
console.log(result);

var c = Foo(1, 2);

function Sum2()
{
    var sum = 0;
    for(var i = 0; i < arguments.length; i++)
    {
        sum += arguments[i];
    }

    return sum;
}

var result2 = Sum2(1,23,45,6,7,8);
console.log(result2);

var f = function(a, b) //Datatype = Function
{
    console.log("This is an anonymous function");
    return -1;
}

//var x = f(1,2);

function functionBuilder(functionType)
{
    if (functionType === 'power')
    {
        return function(a, b)
        {
            var _result = 1;
            for(var i = 0; i < b; i++)
            {
                _result *= a;
            }
            return _result;
        }
    }
    else if (functionType === 'square')
    {
        return function(a)
        {
            return a * a;
        }
    }
    else if (functionType === 'product')
    {
        return function(num1, num2)
        {
            return num1 * num2;
        }
    }
    else
    {
        return undefined;
    }
}

var myFunc = functionBuilder('power');
var result03 = myFunc(3, 2);
console.log(result03);


var myFunc02 = functionBuilder('square');
var result04 = myFunc02(5);
console.log(result04);

var myFunc03 = functionBuilder('product');
var result05 = myFunc03(4, 6);
console.log(result05);