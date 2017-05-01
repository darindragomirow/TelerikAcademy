function solve(args)
{
    var number=args[0];
    let result=0;
    let pow=number.length-1;
    for(let i=0;i<number.length;i+=1)
    {
        if(+number[i] || +number[i]==0)
        {
            result+=(+number[i])*Math.pow(16,pow);
            pow--;
        }
        else
        {
            switch(number[i])
            {
                case 'A': result+=10*Math.pow(16,pow);break;
                case 'B': result+=11*Math.pow(16,pow);break;
                case 'C': result+=12*Math.pow(16,pow);break;
                case 'D': result+=13*Math.pow(16,pow);break;
                case 'E': result+=14*Math.pow(16,pow);break;
                case 'F': result+=15*Math.pow(16,pow);break;
                default: console.log("Incorrect input!");break;
            }
            pow --; 
        }

    }
    console.log(result);

}

solve(['4ED528CBB4']);