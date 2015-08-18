function solve(){
  return function(){
      $.fn.listview = function (data) {
          var $this, id, template, compiledTemp;
          $this = $(this);
          id = '#' + $this.attr('data-template');
          template = $(id).html();
          compiledTemp = handlebars.compile(template);

          for (var i = 0,len=data.length; i < len; i+=1) {
              $this.append(compiledTemp(data[i]));
          }
    };
  };
}

module.exports = solve;