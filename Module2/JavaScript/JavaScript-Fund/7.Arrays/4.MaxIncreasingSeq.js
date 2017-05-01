function solve(args)
{
    let N=+args[0];
    let counter=1;
    let maxCounter=1;

    for(let i=1;i<N-1;i+=1)
    {
        if(+args[i]<+args[i+1])
        {
            counter+=1;
            if(counter>maxCounter)
            {
                maxCounter=counter;
            }
        }
        else
        counter=1;
    }
    console.log(maxCounter);
}