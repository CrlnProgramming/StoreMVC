
$(document).ready(function() {

    $('.bysines__title').click(function(event){
        $('.preloarer,.content__kab').toggleClass('_active');
        });
	$('.preloarer').click(function(event){
       $('.preloarer,.content__kab').removeClass('_active');
		});
    });
