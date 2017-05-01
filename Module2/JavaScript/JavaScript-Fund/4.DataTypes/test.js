function solve(args)
{
  var height=args[0],
  	  width=args[1],
  	  perimeter=2*(height+width),
  	  area=height*width;
  console.log(area.toFixed(2)+' '+perimeter.toFixed(2));
  
}
