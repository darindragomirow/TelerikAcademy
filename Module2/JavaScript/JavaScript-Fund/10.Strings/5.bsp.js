function solve(args)
{
    var str=args[0];
    String.prototype.escape=function()
    {
        var replaced=String(this)
        .replace(/ /g,"&nbsp;");  
        return replaced;
    }
    console.log(str.escape());
}
solve(['Hello World !']);