function solve(args)
{
    var word=args[0].toLowerCase();
    var text=args[1].toLowerCase();
    let index=text.indexOf(word);
    let counter=0;
    while(index!=-1)
    {
        counter+=1;
        index=text.indexOf(word,index+1);
    }
    console.log(counter);

}
solve([
    'we',
    'We arein living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]);