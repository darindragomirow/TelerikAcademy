/*var $element=$('<div>');
$element.append($('<p>'));
$element.appendTo("body");
console.log($element.innerHTML);
console.log("This is a test!");*/


var hbTemplate =`
    <ul>
        {{#student}}
            <li>{{name}}</li>
        {{/student}}
    </ul>
`;

var data = {
    student:[
    {name:'Doncho'},
    {name:'Pesho'},
    {name:'Misho'},
    ]
};

var template = Handlebars.compile(hbTemplate);
console.log(template(data));

