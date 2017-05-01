function solve(args)
{
    var obj=JSON.parse(args[0]);
    String.prototype.format=function(options){

        var text=this;
        for(var option in options)
        {
            var regex=new RegExp('#{'+option+'}','g');
            text=text.replace(regex,options[option]);
        }
        return text;
    }
    console.log(args[1].format(obj));
    
}


solve([
'{ "name": "John" }',
"Hello, there! Are you #{name}?"
]);