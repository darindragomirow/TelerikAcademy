function solve(args)
{
    var url=args[0];
    var protocol='';
    var server='';
    var resource='';

    //Get protocol
    let indexOfDP=url.indexOf(':');
    protocol=url.substring(0,indexOfDP);
    console.log("protocol: "+protocol);
    //Get server
    let start=url.indexOf("//")+2;
    let end=url.indexOf('/',start);
    server=url.substring(start,end);
    console.log("server: "+server);
    //Get resource
    resource=url.substring(end);
    console.log("resource: "+resource);

}
solve([ 'http://telerikacademy.com/Courses/Courses/Details/239']);