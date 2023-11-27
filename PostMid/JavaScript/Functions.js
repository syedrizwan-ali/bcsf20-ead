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