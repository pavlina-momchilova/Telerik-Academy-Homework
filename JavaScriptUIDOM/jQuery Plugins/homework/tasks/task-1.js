function solve() {
    return function (selector) {
        var i,
            $theSelector,
            options,
            $dropdownList,
            $current,
            $optionContainer;

        $theSelector = $(selector)
            .hide();

        options = $theSelector.find('option');
        $dropdownList = $('<div>')
          .addClass("dropdown-list");

        $dropdownList.append($theSelector);
        $current = $('<div>')
           .addClass("current")
           .attr("data-value", "")
           .text('Select value');
        $optionContainer = $('<div>')
           .addClass('options-container')
           .css({ "position": "absolute", "display": "none" });
        $dropdownList.on('click', $current, function () {
            var $container = $('.options-container');
            
            if ($optionContainer.css("display")!=="none") {
                $optionContainer.css("display", "none");
            }
            else {
                $optionContainer.css("display", "");
            }
        });
        $dropdownList.on('click', $optionContainer, function (ev) {
            var $target = $(ev.target);
            var $this = $(this);
            $current.text($target.html());
            $theSelector.val($target.attr("data-value"));
            
        });
        for (i = 0, len = $theSelector[0].length; i < len; i += 1) {
            $('<div>')
                .addClass("dropdown-item")
                .attr({ "data-value": $(options[i]).val(), "data-index": i })
                .text($(options[i]).text())
                .appendTo($optionContainer);
        }
        $dropdownList.appendTo($('body'));
        $dropdownList.append($current);
        $dropdownList.append($optionContainer);
    };
}
module.exports = solve;