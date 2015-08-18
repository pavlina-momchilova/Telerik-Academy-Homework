/* globals $ */

function solve() {
  
  return function (selector) {
      var template = '';
      template += '<div class="container">';
      template += '<h1>Animals</h1>';
      template += '<ul class="animals-list">';
      template += '{{#each animals}}';
      template += '<li>';
      template += '<a href="';
      template += '{{#if url}}';
      template += '{{url}}'+'"';
      template += '{{else}}';
      template += 'http://cdn.playbuzz.com/cdn/3170bee8-985c-47bc-bbb5-2bcb41e85fe9/d8aa4750-deef-44ac-83a1-f2b5e6ee029a.jpg'+'"';
      template += '{{/if}}';
      template += '>';
      template += '{{#if url}}';
      template += 'See a '+ '{{name}}';
      template += '{{else}}';
      template += 'No link for ' + '{{name}}' + ' , here is Batman!';
      template += '{{/if}}';
      template += '</a>';
      template += '</li>';
      template += '{{/each}}';
      template += '</ul>';
      template += '</div>';
   
    $(selector).html(template);   
  };
};

module.exports = solve;