(function($){
    $(document).ready(function(){
        // set 'active' class on the current menu item
        var pathname = window.location.pathname.toLowerCase();
        var page = pathname;
        if (pathname.lastIndexOf('/') >= 0)
            page = pathname.substring(pathname.lastIndexOf('/') + 1);
            
        $('ul.nav').find('a').each(function(index, obj){
            var url = $(obj).attr('href');
            if ( url.indexOf(page) >= 0 )
                $(obj).parent('li').addClass('active');
        });
    });
})(jQuery);