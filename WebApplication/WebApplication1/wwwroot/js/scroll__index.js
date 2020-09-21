(function() {
  'use strict';

  var btnScrollDown = document.querySelector('#scroll_down');

  function scrollDown() {
var windowCoords = document.body.clientHeight;
    $('body, html').animate({scrollTop: windowCoords-70}, 1000);
  }

  btnScrollDown.addEventListener('click', scrollDown);
})();