function solve(args)
{
     
      let max=-10000,
          min =Number.MAX_VALUE,
          num,
          sum=0,
          average;
          
          
          
            for(let i=0;i<args.length;i++)
            {
                 num=+args[i];
                if(num<min)
                {
                    min = num;
                }
                if(num>max)
                {
                    max = num;
                }
                sum += num;
            }
            console.log("min="+(min.toFixed(2)));
            console.log("max="+(max.toFixed(2)));
           console.log("sum="+(sum.toFixed(2)));
            if(args.length!=0)
            average = +(sum/ args.length);
           console.log("avg="+(average.toFixed(2)));

}

solve(['-1', '-1', '-1']);