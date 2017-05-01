function solve(args)
{
    if((args[0] % 5 === 0) && (args[0] % 7 === 0))
    {
        let number=args[0];
        console.log("true "+number);
    }
    else
    {
        console.log("false "+args[0]);
    }
}