function solve(args)
{
    let N=+args[0];
    var arr=[];
    for(let i=0;i<N;i+=1)
    {
        arr.push([]);
    }

    let i=1;

    for(let row=0;row<N;row+=1)
    {
        for(let col=0;col<N;col+=1)
        {
            arr[row][col]=i++;
        }
        i=arr[row][1];
    }
    var result="";
     for(let row=0;row<N;row+=1)
    {
        for(let col=0;col<N;col+=1)
        {
            if(col!=N-1)
            result+=(arr[row][col]+" ");
            else
            result+=(arr[row][col]);

        }
        console.log(result);
        result="";
    }
}
solve(['4']);