var intervalObj;

function onButtonClick() {
    setTimeout(() => {
        alert("Welcome to BCSF20M");
    }, 1000);
}

function onButtonClick02() {
    
    intervalObj = setInterval(() => {
        confirm("Are you awake?");
    }, 1000);

    setTimeout(() => {
        clearInterval(intervalObj);
    }, 10000);
}