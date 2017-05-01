function solve(args)
{
    let N=+args[0];
    let longestSequence=1;
    let currentSequence=1;
    for(let i=1;i<N-1;i+=1)
    {
        if(+args[i]===+args[i+1])
        {
           currentSequence+=1;
        }
        else
           {
               if(currentSequence>longestSequence)
               {
               longestSequence=currentSequence;
               currentSequence=0
               } 
    }
}
if(currentSequence>longestSequence)
            {
                longestSequence=currentSequence;
            }
            console.log(longestSequence);
}