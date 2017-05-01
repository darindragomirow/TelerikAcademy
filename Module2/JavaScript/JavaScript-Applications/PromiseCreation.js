(function(){
    var promise = new Promise(function(resolve,reject){
        setTimeout(function(){
            resolve({id:5,data:"some data"})
            reject('Something very bad happened!')
          },200);
    });

    promise
    .then(function(data){
        console.log(data);
    })
    .catch(function(error){
        console.log(error);
    });
}());