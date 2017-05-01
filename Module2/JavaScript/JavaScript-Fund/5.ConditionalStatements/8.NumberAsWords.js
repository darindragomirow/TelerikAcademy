function solve(args)
{
    let number=args[0];
    let ones=number%10;
    let tens=Math.floor(number/10)%10;
    let hundreds=Math.floor(number/100);

    var str;
     var zeroNine = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
     var tenNineteen =  ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", 
            "seventeen", "eighteen", "nineteen"];
     var lastZero =  ["zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
     
     if(number<10)
     {
         console.log(zeroNine[number].charAt(0).toUpperCase()+zeroNine[number].substring(1));
     }
     else if(number>9 && number<20)
     {
         
         console.log(tenNineteen[ones].charAt(0).toUpperCase()+tenNineteen[ones].substring(1))
     }
     else if(number>19 && number<100)
     {
         if(number%10 === 0)
         {
             console.log(lastZero[tens].charAt(0).toUpperCase()+lastZero[tens].substring(1));
         }
         else
         {
            
             console.log(lastZero[tens].charAt(0).toUpperCase()+lastZero[tens].substring(1)+" "+zeroNine[ones]);
             
         }
     }
     else if(number>99 && number<1000)
     {
         if(number%100 === 0)
         {
             console.log(zeroNine[hundreds].charAt(0).toUpperCase()+zeroNine[hundreds].substring(1)+" hundred");
         }
         else if(tens === 0)
         {
             console.log(zeroNine[hundreds].charAt(0).toUpperCase()+zeroNine[hundreds].substring(1)+" hundred and "+zeroNine[ones]);
         }
     else if(number%100<20 && number%100>9)
        {
            console.log(zeroNine[hundreds].charAt(0).toUpperCase()+zeroNine[hundreds].substring(1)+" hundred and "+tenNineteen[ones]);
        }
    else if(number%100<10)
    {
        console.log(zeroNine[hundreds].charAt(0).toUpperCase()+zeroNine[hundreds].substring(1)+" hundred and "+zeroNine[ones]);
    }
    else if(ones===0)
    {
        console.log(zeroNine[hundreds].charAt(0).toUpperCase()+zeroNine[hundreds].substring(1)+" hundred and "+lastZero[tens]); 
    }
    else
    {
        console.log(zeroNine[hundreds].charAt(0).toUpperCase()+zeroNine[hundreds].substring(1)+" hundred and "+lastZero[tens]+" "+zeroNine[ones]);
    }

}
}
solve(['10']);