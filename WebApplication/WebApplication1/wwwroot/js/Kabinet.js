
$(document).ready(function() {

    $('.Li__kab').click(function(event){
        $('.preloarer,.content__kab').toggleClass('_active');
        });
	$('.preloarer').click(function(event){
       $('.preloarer,.content__kab').removeClass('_active');
		});
    });
