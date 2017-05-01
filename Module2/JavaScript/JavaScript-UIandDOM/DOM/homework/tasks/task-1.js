/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

  return function (id, contents) {
     var element,
         docFragment=document.createDocumentFragment();
        if(typeof id === 'string')
        {
         element=document.getElementById(id);
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
};