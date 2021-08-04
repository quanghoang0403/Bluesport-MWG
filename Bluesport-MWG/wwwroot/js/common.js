$(document).ready(function() {

  // click open list menu header
  $('.list-menu > li > a').click(function(e) {
    e.preventDefault();
    var notthis = $('.active').not(this);
    notthis.toggleClass('active').next('.wrap-menu').fadeToggle();
    $(this).toggleClass('active').next().fadeToggle();
    $('body').css({"overflow": "hidden"});
    if($('.list-menu > li > a').hasClass('active')) {
      $('.bgcover').fadeIn();
    } else {
      $('.bgcover').fadeOut();
    }
  });
  $('.bgcover').click(function() {
    $('.wrap-menu').fadeOut();
    $('.search-show').fadeOut();
    $('.header-search').removeClass('act');
    $(this).fadeOut();
    $('.list-menu > li > a').removeClass('active');
    $('body').css({"overflow": "scroll"});
  });


  // Click search header
  $('.header-search input').click(function() {
    $('.search-show').fadeIn();
    $('.bgcover').fadeIn();
    $('.header-search').addClass('act');
    $('body').css({"overflow": "hidden"});
  });
})  