/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
  return function (selector) {
    if(typeof selector !== 'string' || !($(selector).length))
    {
      throw Error("Invalid selector");
    }
    var $element=$(selector);
   var $buttons=$element.find('.button');
   $buttons.html('hide');

   $buttons.on('click',function(){
     $this=$(this);
     var nextSibling=$this.next();
     while(nextSibling)
     {
      if(nextSibling.css('class') === 'content')
      {
        if(nextSibling.css('display') === 'none')
        {
          nextSibling.css('display','');
          $this.html('hide');
          break;
        }else
        {
          nextSibling.css('display','none');
          $this.html('show');
          break;
        }
      }
      nextSibling=nextSibling.next();
     }
   })
  };
};

module.exports = solve;