function solve()
{
    return function(id,array)
    {
        var element,
            docFragment=document.createDocumentFragment();
        if(typeof id === 'string')
        {
         element=document.getElementById(id);
            if(element == null)
            {
                throw new Error();
            }
        }
        else if(!(element instanceof HTMLElement))
        {
            throw "Invalid element";
        }
        else
        {
            element=id;
        }
        if(contents == null || contents == undefined)
        {
           throw new Error();
        }
    
       
        //Remove the content of the element
        element.textContent='';

        var length=array.length;
        for(let i=0;i<length;i+=1)
        {
            var child=document.createElement('div');
            if(typeof array[i] !== 'string' && typeof array[i] !== 'number')
            {
                throw new Error();
            }
            child.textContentt=array[i];
            docFragment.appendChild(child) 
        }
        element.appendChild(docFragment);
    };
}