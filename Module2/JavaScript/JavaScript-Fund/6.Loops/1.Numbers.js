function solve(args)
{
    let N=+args[0];
    var result="";

    for(let i=1;i<=N;i+=1)
    {
        if(i !== N)
        result+=(i+" ");
        else
        result+=i;
       
    }
    console.log(result);
}

solve(['6']);