$(document).ready(function() {
    $('.register').click(function(event){
    	$('.header__style').toggleClass('_active');
        $('.preloarer').toggleClass('_active');
        $('.pozition__z').toggleClass('_active');
        });
	$('.form-close').click(function(event){
       $('.preloarer').removeClass('_active');
       $('.pozition__z').removeClass('_active');
       $('.header__style').removeClass('_active');
		});
    });

$(document).click( function(e){
    if ( $(e.target).closest('.form,.register').length ) {
        // клик внутри элемента 
        return;
    }
    // клик снаружи элемента 
    $('.pozition__z,.preloarer,.header__style').removeClass('_active');
});


const inputs = [...document.getElementsByTagName('input')];
inputs.forEach((input) => { 
	input.addEventListener('keyup', (event) => {
		input.setAttribute('value', input.value);
	});
});