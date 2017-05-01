function solve(args)
{
    var str=args[0];
    let openedBrackets=0;
    let closedBrackets=0;
    for(let i=0;i<str.length;i+=1)
    {
        if(str[i]=='(')
        openedBrackets+=1;
        else if(str[i]==')')
        closedBrackets+=1;
    }
    if(openedBrackets==closedBrackets)
    console.log("Correct")
    else
    console.log("Incorrect")
}