function onButtonClick()
{
    var practiceDiv = document.getElementById('practiceDiv');
    var link = document.createElement('a');
    link.innerHTML = 'PUCIT Website';
    link.href = 'http://www.pucit.edu.pk';

    practiceDiv.append(link);

    var body = link.parentElement.parentElement;
    
    var h2 = document.createElement('h2');
    h2.innerText = 'This is a dynamic heading';

    body.append(h2);
}

function onButtonClick02()
{
    var divs = document.getElementsByTagName('div');
    console.log(divs);

    while(divs.length > 0)
    {
        var parent = divs[0].parentElement;
        parent.removeChild(divs[0]);
    }
}

function onButtonClick03()
{
    var body = document.getElementsByTagName('body');
    console.log(body[0].innerHTML);
    console.log(body[0].innerText);
}