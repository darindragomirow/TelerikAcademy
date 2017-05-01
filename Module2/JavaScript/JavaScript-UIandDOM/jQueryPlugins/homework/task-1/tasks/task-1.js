function solve(){
  return function(selector){
    var $mainDiv = $('<div>')
    .addClass("dropdown-list");
     var $select = $(selector)
    .appendTo($mainDiv);
    $('<div>')
    .className = 'current'
    .attr("data-value",$select.children().first().val())
    .html($select.children().first().html())
    .click(function () {
        $options.toggle();
        $(this).html("Select a value");
      })
    .appendTo($mainDiv);
    var $options = $('<div>')
    .addClass('options-container')
    .css('position','absolute')
    .css('display','none')
    .on("click", ".dropdown-item", makeSelection)
    .appendTo($mainDiv);

    $select.hide()
    .find('option')
    .each(function(index)
    {
      $('<div>')
      .addClass('dropdown-item')
      .attr('data-value','value-'+(index+1))
      .attr('data-index',index)
      .text('Option '+(index+1))
      .appendTo($options);
    });
    $('body').append($mainDiv);
  };
}

module.exports = solve;