function solve(args)
{
            let N=+args[0];
            var array=[];
            for(let i=0;i<N;i+=1)
            {
                array[i]=args[i+1];
            }

            let minvalue;
            let temp;
            for(let j=0;j<N-1;j+=1)
            {
                minvalue = j;
                
                for(let i=j+1;i<N;i+=1)
                {
                    if(array[i]<array[minvalue])
                    {
                        minvalue = i;
                    }
                }
                if(minvalue!=j)
                {
                    temp = array[j];
                    array[j] = array[minvalue];
                    array[minvalue] = temp;
                }
            }
            for (let i = 0; i < N; i++)
            {
                console.log(array[i]);
            }
        
}