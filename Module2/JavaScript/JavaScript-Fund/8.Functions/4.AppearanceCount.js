function solve(args)
{
    function CountAppearance(number,array)
    {
        let counter=0;
        for(let i=0;i<array.length;i+=1)
        {
            if(array[i]==number)
            counter+=1;
        }
        console.log(counter);
    }

    let N=+args[0];
    let number=+args[2];
    var array=args[1].split(' ');
   
    CountAppearance(number,array);

}
solve(['5','1','1','4','5','1','1']);