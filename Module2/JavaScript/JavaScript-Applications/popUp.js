(function(){
    var popUpDiv = document.createElement('div');
    const promise = new Promise((resolve, reject) => {
    setTimeout(resolve(function(){
    }), 2000);
    promise.then(function(){
        const promise2 = function (message) {
    return new Promise((resolve) => {
        setTimeout(() => {
            window.location.replace('http://www.something.com');
            resolve(message + ' going to hell');
        }, 3000);
    })
};
    })

