var el=document.getElementsByTagName('input')[0];

var msgContainer=document.getElementById('msgContainer');

function sendMessage()
{
 var msg=el.value;
        el.value='';
    
    var msgElement=document.createElement('p');
    msgElement.innerText=msg;
    msgElement.style.color='blue';
    msgContainer.appendChild(msgElement);
}

el.addEventListener('keydown',function(e)
{
    if(e.keyCode === 13)
    {
       sendMessage();
    }
});
document.getElementById('send-button')
.addEventListener('click',sendMessage);