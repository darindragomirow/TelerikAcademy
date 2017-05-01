
(function(){
    var begin = new Date();
    var promise1 = new Promise(function(resolve,reject){
        setTimeout(function(){
            resolve('This is promise one.');
        },200);
    });
    
    var promise2 = new Promise(function(resolve,reject){
        setTimeout(function(){
            resolve('This is promise two.');
        },5000);
    });

    Promise.all([promise1,promise2])
    .then(function(results){
        console.log(results);
    });
var end = new Date();
console.log(end - begin);
}());

