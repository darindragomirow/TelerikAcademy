function solve(args)
{
    function SayHello(name)
    {
        console.log("Hello, "+name+"!");
    }

    var name=args[0];
    SayHello(name);
}