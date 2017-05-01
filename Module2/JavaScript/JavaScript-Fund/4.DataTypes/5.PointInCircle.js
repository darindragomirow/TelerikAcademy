function solve(args)
{
    let x=+args[0];
    let y=+args[1];
    let radius=2;
    let distance=Math.sqrt(x*x+y*y);
    if( distance <= radius )
    console.log("yes "+distance.toFixed(2));
    else
    console.log("no "+distance.toFixed(2));
}
