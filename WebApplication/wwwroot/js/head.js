(function () {

	var scrollHeight = document.documentElement.clientHeight;

	const header = document.querySelector('.header__style');
	const header_list = document.querySelector('.header__list');
	const header_hover = document.querySelector('.list__item__kab');
	const header_logo = document.querySelector('.glav__logo');
	window.onscroll = () => {
		if (window.pageYOffset > 80 ) {
			header.classList.add('header__active');
			header_list.classList.add('header__list__active');
			header_list.classList.remove('header__list');
			header_logo.classList.add('white__logo');
			header_logo.classList.remove('glav__logo');
			header_hover.classList.add('list__item__black__kab');
			header_hover.classList.remove('list__item__kab');
		}
		else {
			header.classList.remove('header__active');
			header_list.classList.remove('header__list__active');
			header_list.classList.add('header__list');
			header_logo.classList.remove('white__logo');
			header_logo.classList.add('glav__logo');
			header_hover.classList.add('list__item__kab');
			header_hover.classList.remove('list__item__black__kab');
		}
	};
}());

(function(){
                var win = $(window).height();
                $('.bottom__scroll__bisines').click(function () {
                    $('body,html').animate({
                        scrollTop: win
                    }, 800);
                    return false;
                });
            });