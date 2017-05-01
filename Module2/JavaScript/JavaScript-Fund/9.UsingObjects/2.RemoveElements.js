function solve(args)
{
    var array=args;
    Array.prototype.remove=function(item){
        var result=[];
        for(let i=0;i<this.length;i+=1)
        {
            if(this[i]!=item)
            result.push(this[i]);
        }
        return result;
    }
    console.log(array.remove(args[0]).join('\n'));
     
    
}
solve(['1','1','2','2','1']);