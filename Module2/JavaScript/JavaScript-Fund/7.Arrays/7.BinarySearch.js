function solve(args)
{
            let N=+args[0];
            let X=+args[N-1];
            var array=[];
            for(let i=0;i<N;i+1)
            {
                array[i]=+args[i+1];
            }
            

            let min = 0;
            let max = N-1;
            let mid;
            while( min <= max )
            {
                mid = (min + max) / 2;
                if(array[mid]==X)
                {
                    console.log(mid); return;
                }else if(array[mid]>X)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }

            }
            console.log(-1);
}