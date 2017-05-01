function solve(args)
{
    function firstLarger(array)
    {
        for(let i=1;i<array.length-1;i+=1)
        {
            if(+array[i]>+array[i+1] && +array[i]>+array[i-1])
            return i;
        }
        return -1;
    }
    var array=args[1].split(' ');
    console.log(firstLarger(array));
}