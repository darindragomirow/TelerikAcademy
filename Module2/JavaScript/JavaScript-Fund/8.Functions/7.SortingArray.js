function solve(args)
{

    function maxElement(array,index)
    {
        let maxElement=array[index];
        for(let i=index;i<array.length;i+=1)
        {
            if(array[i]>maxElement)
            {
                maxElement=array[i];
                let temp=array[i];
                array[i]=array[index];
                array[index]=temp;
            }
        }
        return maxElement;
    }

    let N=+args[0];
    var array=args[1].split(' ');
    var riversed=new Array(N);
    for(let i=0,j=N-1;i<N;i+=1,j-=1)
    {
        riversed[j]=maxElement(array,i);
    }
    
        console.log(riversed.join(' '));


}