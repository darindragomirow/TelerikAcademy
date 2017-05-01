function solve(args)
{
    var html=args;
    var text='';
    var regex=/<.*?>/g;
    for(let i=0;i<html.length;i+=1)
    {
        text+=html[i].replace(regex,'').trim();
    }
    
    console.log(text);
}




solve([
    '<html>',
    '  <head>',
    '    <title>Sample site</title>',
    '  </head>',
    '  <body>',
    '    <div>text',
    '      <div>more text</div>',
    '      and more...',
    '    </div>',
    '    in body',
    '  </body>',
    '</html>'
]);