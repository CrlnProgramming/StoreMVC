
$(document).ready(function() {

    $('.item__sort__1').click(function(event){
    	$('.sorting__box__active__item,.tab__sort,.sorting__box__active__item').removeClass('_active__sort');
        $('.item__sort__1').toggleClass('_active__sort');
        });
    $('.item__sort__2').click(function(event){
    	$('.sorting__box__active__item,.tab__sort,.sorting__box__active__item').removeClass('_active__sort');
        $('.item__sort__2').toggleClass('_active__sort');
        });
    $('.item__sort__3').click(function(event){
    	$('.sorting__box__active__item,.tab__sort,.sorting__box__active__item').removeClass('_active__sort');
        $('.item__sort__3').toggleClass('_active__sort');
        });
    $('.item__sort__4').click(function(event){
    	$('.sorting__box__active__item,.tab__sort,.sorting__box__active__item').removeClass('_active__sort');
        $('.item__sort__4').toggleClass('_active__sort');
        });
    $('.item__sort__5').click(function(event){
    	$('.sorting__box__active__item,.tab__sort,.sorting__box__active__item').removeClass('_active__sort');
        $('.item__sort__5').toggleClass('_active__sort');
        });
    $('.item__sort__6').click(function(event){
    	$('.sorting__box__active__item,.tab__sort,.sorting__box__active__item').removeClass('_active__sort');
        $('.item__sort__6').toggleClass('_active__sort');
        });
    $('.item__sort__7').click(function(event){
    	$('.sorting__box__active__item,.tab__sort,.sorting__box__active__item').removeClass('_active__sort');
        $('.item__sort__7').toggleClass('_active__sort');
        });
});
$(document).click( function(e){
    if ( $(e.target).closest('.sorting__box__item').length ) {
        // клик внутри элемента 
        return;
    }
    // клик снаружи элемента 
    $('.sorting__box__active__item,.tab__sort,.sorting__box__active__item').removeClass('_active__sort');
});
