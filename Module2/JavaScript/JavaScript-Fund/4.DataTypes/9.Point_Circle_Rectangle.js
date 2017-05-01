function solve(args)
{
    let x=args[0];
    let y=args[1];
    let r = 1.5;
            let x0 = 1;
            let y0 = 1;
            var isInCircle=(Math.sqrt((x-x0)*(x-x0)+(y-y0)*(y-y0))<=r);
            var isInRect = (x <= 5 && x >= -1) && (y <= 1 && y >= -1);
            var IsInCircle = (isInCircle ? "inside circle" : "outside circle");
            var IsInRectangle = (isInRect ? "inside rectangle" : "outside rectangle" );
            console.log(IsInCircle+" "+IsInRectangle);
}