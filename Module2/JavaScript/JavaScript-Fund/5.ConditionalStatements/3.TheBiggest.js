function solve(args)
{
    let firstNumber=+args[0],
        secondNumber=+args[1],
        thirdNumber=+args[2];

        let biggestNumber=Math.max(Math.max(firstNumber,secondNumber),thirdNumber);
        console.log(biggestNumber);
}
