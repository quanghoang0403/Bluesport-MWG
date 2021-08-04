$(document).ready(function() {

    //Banner slider top
    $(".slider-bannertop").owlCarousel({
      navigation: true,
      pagination: true,
      navigationText: ["",""],
      items : 1,
      itemsDesktop : [1199,1],
      itemsDesktopSmall : [979,1],
    });

    //click sap xep 'sort'
    $(".click-sort").click(function() {
      $(".sort-select-main").fadeToggle(300);
    });

    //click border blue & show item FILTER
    $('.box-quicklink__item').on('click', function(event) {
      event.preventDefault();
      $(this).toggleClass('border-blue');
    });
    $('.c-btnbox').on('click', function(event) {
      event.preventDefault();
      $(this).toggleClass('border-blue');
    });
    $('.layout-nh2__item').on('click', function(event) {
      event.preventDefault();
      $(this).toggleClass('border-add');
    });


    //click open item filter
    $('.jsTitle').click(function(e) {
      e.preventDefault();
      var notthis = $('.active').not(this);
      notthis.toggleClass('active').next('.filter-show').fadeToggle(300);
      $(this).toggleClass('active').next().fadeToggle("fast");
      if($('.jsTitle').hasClass('active')) {
        $('body').addClass('bg-black');
        $('.breadcrumb').addClass('heighter');
      }else {
        $('body').removeClass('bg-black');
        $('.breadcrumb').removeClass('heighter');
      }
      
    });
    $(".btn-filter-close").click(function() {
      $(".filter-show").fadeOut(300);
      $('.jsTitle').removeClass('active');
      $('body').removeClass('bg-black');
      $('body').css({"overflow": "scroll"});
    });



    //click open & close info
    $(".info__title").click(function() {
      $(this).toggleClass('remove-arrow');
      $(".info__content").fadeToggle(200);
    });

    $('.info__content button').click(function(){
      $('.info__content').hide();
      $('.info__title').removeClass('active');
    });

    //click layout me va be
    $(".layout-nh2__item").click(function() {
      $(this).toggleClass('active');
    });


    //click open & close So sanh
    $(".item-ss").click(function() {
        $(".content-ss").addClass('active');
    });
    $(".btn-ss--close").click(function() {
        $(".content-ss").removeClass('active');
    });


    //scroll hide show gradient total filter
    var wrapper = document.getElementById('wrapper');
    wrapper.onscroll = function (evt) {
      if (wrapper.scrollTop + window.innerHeight >= wrapper.scrollHeight) {
        $('.bg-whitefix').fadeOut(200);
      }
      else {
        $('.bg-whitefix').fadeIn(200);
      }
    }
})
