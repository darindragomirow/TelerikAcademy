function solve(args)
{
    let A = args[0];
    let B = args[1];
    let C = args[2];

            if ((A > 0 && B > 0 && C > 0) || ((A > 0 || B > 0 || C > 0) && ((A < 0 && B < 0) || (B < 0 && C < 0) || (A < 0 && C < 0))))
            {
               console.log("+");
            }
            else if ((A < 0 && B < 0 && C < 0) || ((A < 0 || B < 0 || C < 0) && ((A > 0 && B > 0) || (B > 0 && C > 0) || (A > 0 && C > 0))))
            {
                console.log("-");
            }
            else if (A == 0 || B == 0 || C == 0)
            {
                console.log(0);
            }
}

