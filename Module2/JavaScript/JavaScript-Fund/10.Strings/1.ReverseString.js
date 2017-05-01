function solve(args)
{
    var str=args[0];
    var reversed=[];
    for(let i=str.length-1,j=0;i>=0;i-=1,j+=1)
    {
        reversed[j]=str[i];
    }
    var result='';
    for(let i=0;i<reversed.length;i+=1)
   result=result+reversed[i];
    console.log(result)
}