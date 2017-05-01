function solve(args)
{
    let number=args[0];
    let thirdDigit=+(Math.floor(number/100))%10;
    
    if(thirdDigit===7)
    console.log("true");
    else
    console.log("false "+thirdDigit);
}

