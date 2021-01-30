$(document).on('ready', function () {
    $(".slick-list").addClass("slick-list-max-height");


    // initialization of header
    $.HSCore.components.HSHeader.init($('#js-header'));
    // initialization of go to
    $.HSCore.components.HSGoTo.init('.js-go-to');

    // initialization of carousel
    $.HSCore.components.HSCarousel.init('.js-carousel');

    const quote = document.querySelector('#home-quote');
    if (quote) {
        // initialization of text animation (typing)
        $(".u-text-animation.u-text-animation--typing").typed({
            strings: [quote.dataset.quote1, quote.dataset.quote2, quote.dataset.quote3],
            typeSpeed: 60,
            loop: true,
            backDelay: 1500
        });
    }
});

/*  var slider = new MasterSlider();

  slider.control('arrows', {
  autohide: true,
      overVideo: true,
      class: "g-mt-130--sm"
  });

  slider.setup("masterslider", {
     width: 1920,
      height: 820,
      minHeight: 0,
      space: 0,
      start: 1,
      grabCursor: true,
      swipe: true,
      mouse: true,
      keyboard: true,
      layout: "fullwidth", //boxed fullscreen fullwidth
      wheel: false,
      autoplay: true,
      instantStartLayers: true,
      loop: true,
      shuffle: false,
      preload: 0,
      heightLimit: true,
      autoHeight: false,
      smoothHeight: true,
      endPause: false,
      overPause: false,
      fillMode: "fill",
      centerControls: false,
      startOnAppear: false,
      layersMode: "center",
      autofillTarget: "",
      hideLayers: false,
      fullscreenMargin: 0,
      speed: 10,
      dir: "h",
      parallaxMode: 'mouse:y-only',
      view: "fade"
  });

*/