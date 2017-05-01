function solve(args)
{
    let A=+args[0],
        B=+args[1],
        C=+args[2],
        D=+args[3],
        E=+args[4];

         if(A>B && A>C && A>D && A>E)
            {
                console.log(A);
            }
            else if(B>C && B>D && B>E)
            {
                console.log(B);
            }
            else if(C>D && C>E)
            {
                console.log(C);
            }
            else if(D>E)
            {
              console.log(D);
            }
            else
            {
                console.log(E);
            }
}