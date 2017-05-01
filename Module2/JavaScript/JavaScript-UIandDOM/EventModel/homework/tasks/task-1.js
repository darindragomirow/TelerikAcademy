/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve(){
  return function (selector) {
    var element;
    if(typeof selector !== 'string' && !(selector instanceof HTMLElement))
    {
      throw new Error();
    }
    if(typeof selector === 'string')
    {
      element=document.getElementById(selector);
      if(element === null)
      throw new Error();
    }
    else element=selector;

    var buttonsList=element.getElementsByClassName('button');
    var contentsList=element.getElementsByClassName('content');
    for(let i=0,len=buttonsList.length;i<len;i+=1)
    {
      buttonsList[i].textContent="hide";
      buttonsList[i].addEventListener('click',changeVisibility);
    }
    
    function changeVisibility(e)
    {
      var targetElement=e.target;
      var targetElementSibling=findSibling(targetElement);
      if(targetElementSibling !== null)
      {
        if(targetElementSibling.display === '')
        {
          targetElement.textContent='show';
          targetElementSibling.display='none';
        }
        else
        {
          targetElement.textContent='hide';
          targetElementSibling.display='';
        } 
      }
    }
    function findSibling(element)
    {
      var currentSibling=element.nextElementSibling;
      if(currentSibling.className === 'content')
      {
        return currentSibling;
      }
      else return null;
      return findSibling(currentSibling);
    }



  };
};

module.exports = solve;