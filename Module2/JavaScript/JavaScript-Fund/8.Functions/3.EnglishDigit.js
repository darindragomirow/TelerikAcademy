function solve(args)
{
    function LastDigit(number)
    {
        let lastDigit = (number % 10);
            var digits=["zero","one","two","three","four","five","six",
            "seven","eight","nine"];
            console.log(digits[lastDigit]);
    }
    let number=+args[0];
    LastDigit(number);
}

solve(['53']);