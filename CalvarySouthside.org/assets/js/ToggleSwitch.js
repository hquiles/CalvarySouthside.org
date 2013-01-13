$(document).ready(function(){

    $('.ToggleSwitch').find('a').on('click', function(){
        
        var newValue = $(this).hasClass("ToggleSwitchOff");

        var newClass = newValue ? 'ToggleSwitchOn' : 'ToggleSwitchOff';
        var oldClass = newValue ? 'ToggleSwitchOff' : 'ToggleSwitchOn';
        var leftPosition = newValue ? '0px' : '-25px';
    
        $(this).animate(
            {
                left: leftPosition
            },
            150,
            'swing',
            function() {
                    $(this).removeClass(oldClass).addClass(newClass);
                    $(this).find('input[type=hidden]').val(newValue);
                }
        ); 

        return false;
    });

});