function solve(args)
{
    let N=+args[0];
    let mostFrequent=1;
    let number;
    let current=1;
    for(let i=1;i<N;i+=1)
    {
        for(let j=i+1;j<N;j+=1)
        {
            if(+args[i]===+args[j])
            {
                current+=1;
            }
        }
        if(current>mostFrequent)
        {
        mostFrequent=current;
        number=+args[i];
        }
        current=1;
    }
    console.log(number+" ("+mostFrequent+ " times)");
}