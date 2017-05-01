function solve(args)
{
    let number=args[0];
    if(number<2)
    {
    return false;
    }
     for(let i=2;i<Math.sqrt(number);i++)
            {
                if(number % i === 0)
                {
                return false;
                }
            }
            return true;
}
