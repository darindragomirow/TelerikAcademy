function solve(args)
{
             let a = args[0],
             b = args[1],
             c = args[2],
             x1,x2;
             D = (b * b) - (4 * a * c);
           Dsqrt = Math.sqrt(D);
    
            if (D < 0)
            {
               console.log("no real roots"); return;
            }
            else if(D==0)
            {
                x1 = (-b / (2 * a));
               console.log("x1=x2="+x1.toFixed(2));
            }
            else if(D>0)
            {
                x1 = (-b - Dsqrt) / (2 * a);
                x2 = (-b + Dsqrt) / (2 * a);
               if(x1>x2)
               {
                   console.log("x2="+x2.toFixed(2)+"; "+"x1="+x1.toFixed(2));
                   
               }
               else
               {
                   console.log("x1="+x1.toFixed(2)+"; "+"x2="+x2.toFixed(2));
                   
               }
            }
                
            
}