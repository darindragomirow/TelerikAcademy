function solve(args)
{
    let N=+args[0];
    var array=[];

    for(let i=0;i<N;i+=1)
    {
        array[i]=i*5;
        console.log(array[i]);
    }
    
    
}

solve('5');