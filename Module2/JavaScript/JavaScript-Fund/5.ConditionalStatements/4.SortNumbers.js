function solve(args)
{
    let firstNumber=+args[0];
    let secondNumber=+args[1];
    let thirdNumber=+args[2];

    let biggest=(Math.max(Math.max(firstNumber,secondNumber),thirdNumber));
    if(biggest===thirdNumber)
    {   
     
        console.log(thirdNumber+" "+Math.max(firstNumber,secondNumber)+" "+Math.min(firstNumber,secondNumber));
       
    }
    else if(biggest===secondNumber)
    {   

        console.log(secondNumber+" "+Math.max(firstNumber,thirdNumber)+" "+Math.min(firstNumber,thirdNumber));
   
    }
    else
    {
      
        console.log(firstNumber+" "+Math.max(secondNumber,thirdNumber)+" "+Math.min(secondNumber,thirdNumber));

    }
   
}