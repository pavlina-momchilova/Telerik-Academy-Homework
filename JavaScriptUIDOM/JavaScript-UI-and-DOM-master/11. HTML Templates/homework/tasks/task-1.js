/* globals $ */

function solve() {
  
    return function (selector) {
      var template = '';
      template += '<table class="items-table">';
      template += '<thead>';
      template += '<tr>';
      template += '<th>#</th>';
      template += '{{#each headers}}';
      template += '<th>{{this}}</th>'
      template += '{{/each}}';
      template += '</tr>';
      template += '</thead>';
      template += '<tbody>';
      template += '{{#each items}}';
      template += '<tr>';
      template += '<td>{{@index}}';
      template += '<td>';
      template += '{{col1}}';
      template += '</td>';
      template += '<td>';
      template += '{{col2}}';
      template += '</td>';
      template += '<td>';
      template += '{{col3}}';
      template += '</td>';
      template += '</tr>';
      template += '{{/each}}';
      template += '</tbody>';
      template += '</table>';
    $(selector).html(template);
  };
};

module.exports = solve;