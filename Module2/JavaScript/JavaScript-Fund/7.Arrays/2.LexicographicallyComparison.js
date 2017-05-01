function solve(args)
{
    var str1=args[0];
    var str2=args[1];


    let end=str1.length<str2.length ? str1.length:str2.length;
    if(str1.length!==str2.length)
    {
    console.log(str1.length>str2.length ? '>':'<');return;
    }

    for(let i=0;i<end;i+=1)
    {
        if(str1[i]==str2[i])
        {
            continue;
        }
        else
        {
            console.log(str1[i]>str2[i] ? '>':'<');return;     
        }
    }

    console.log("=");
    
}

solve(['food','food']);