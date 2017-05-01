function solve(args)
{
    function isLarger(array)
   {
            let counter=0;
            for(let i=1;i<array.length-1;i+=1)
            {

             if(+array[i]>+array[i-1] && +array[i]>+array[i+1])
             counter+=1;
            }
            return counter;   
       
   }

   let N=+args[0];
   var array=args[1].split(' ');
   console.log(isLarger(array));
}

solve(['6','2 1 4 3 5 2']);