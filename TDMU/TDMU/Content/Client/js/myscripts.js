/**************************************************************************
* Author: Nguyen Ba Anh Dung
* Author URL: pnssoftware.com
* Mail: dungnb4@gmail.com
**************************************************************************/


/* --------------------------------------------------------	
	 Thuc thi slider
   --------------------------------------------------------	*/
function initMainSlider(){
  $('.tp-banner').show().revolution({
    dottedOverlay:"none",
    delay:10000,
    startwidth:1170,
    startheight:500,
    hideThumbs:200,

    thumbWidth:100,
    thumbHeight:50,
    thumbAmount:5,

    navigationType:"bullet",
    navigationArrows:"solo",
    navigationStyle:"preview4",

    touchenabled:"on",
    onHoverStop:"on",

    swipe_velocity: 0.7,
    swipe_min_touches: 1,
    swipe_max_touches: 1,
    drag_block_vertical: false,

    parallax:"mouse",
    parallaxBgFreeze:"on",
    parallaxLevels:[7,4,3,2,5,4,3,2,1,0],

    keyboardNavigation:"off",

    navigationHAlign:"center",
    navigationVAlign:"bottom",
    navigationHOffset:0,
    navigationVOffset:20,

    soloArrowLeftHalign:"left",
    soloArrowLeftValign:"center",
    soloArrowLeftHOffset:20,
    soloArrowLeftVOffset:0,

    soloArrowRightHalign:"right",
    soloArrowRightValign:"center",
    soloArrowRightHOffset:20,
    soloArrowRightVOffset:0,

    shadow:0,
    fullWidth:"on",
    fullScreen:"off",

    spinner:"spinner4",

    stopLoop:"off",
    stopAfterLoops:-1,
    stopAtSlide:-1,

    shuffle:"off",

    autoHeight:"off",           
    forceFullWidth:"off",           



    hideThumbsOnMobile:"off",
    hideNavDelayOnMobile:1500,            
    hideBulletsOnMobile:"off",
    hideArrowsOnMobile:"off",
    hideThumbsUnderResolution:0,

    hideSliderAtLimit:0,
    hideCaptionAtLimit:0,
    hideAllCaptionAtLilmit:0,
    startWithSlide:0,
    videoJsPath:"rs-plugin/videojs/",
    fullScreenOffsetContainer: "" 
  });
}

function initCarousel() {
   var flexslider;

  //tim min max item khi resize window 
  function getGridSize() {
    return (window.innerWidth < 600) ? 1 :
           (window.innerWidth < 900) ? 2 : 3;
  }

  $('.a-slider').flexslider({
      animation: "slide",
      touch: true,
      customDirectionNav: $(".custom-navigation a"),
      controlNav: false,
      animationLoop: true,
	  slideshowSpeed: 5000,
      itemWidth: 230,
      itemMargin: 15,
      move: 1,
      minItems: getGridSize(),
      maxItems: getGridSize(),
      start: function(slider){
        flexslider = slider;
      } 
  });

  $('.n-slider').flexslider({
      animation: "fade",
      touch: true,
      controlNav: false,
      pauseOnAction: true
  });

  //cap nhat lai min max item khi resize window
  $(window).resize(function() {
    var gridSize = getGridSize();
 
    flexslider.vars.minItems = gridSize;
    flexslider.vars.maxItems = gridSize;
  });
}

function initSlider() {
  $('.n-slider').flexslider({
      animation: "fade",
	  slideshowSpeed: 5000,
      touch: true,
      controlNav: false,
      pauseOnAction: true
  });
}
/* --------------------------------------------------------	
	 Thuc thi google maps
   --------------------------------------------------------	*/
function initMap(){
    //Danh sach cac dia diem 
    var locations = {
        'cn1': [10.980582,106.674586,"<h4>TDM University</h4>"]
    };

    //Khai bao va thuc thi google map
    var myOptions = {zoom:15,center:new google.maps.LatLng(locations['cn1'][0],locations['cn1'][1]),mapTypeId: google.maps.MapTypeId.ROADMAP};
    map = new google.maps.Map(document.getElementById("gmap_canvas"), myOptions);
    marker = new google.maps.Marker({map: map,position: new google.maps.LatLng(locations['cn1'][0], locations['cn1'][1])});
    // infowindow = new google.maps.InfoWindow({content:locations['cn1'][2] });
    // google.maps.event.addListener(marker, "click", function(){infowindow.open(map,marker);});
    // infowindow.open(map,marker);

    // //pan toi dia diem co toa do trong mang locations khi click chuot vao menu
    // $('.map-item').click(function(e){
    //     e.preventDefault();
    //     //tat cua so thong tin cu
    //     infowindow.close();
    //     var data = locations[$(this).data('map')];
    //     //lay toa do tu mang
    //     var laLatLng = new google.maps.LatLng( data[0],  data[1]);
    //     //set diem danh dau tren ban do
    //     marker = new google.maps.Marker({map: map,position: new google.maps.LatLng(data[0], data[1])});
    //     //set cua so thong tin
    //     infowindow = new google.maps.InfoWindow({content: data[2]});
    //     //mo cua so thong tin khi click vao marker
    //     google.maps.event.addListener(marker, "click", function(){infowindow.open(map,marker);});
    //     //chuyen toi toa do vua lay duoc
    //     map.panTo(laLatLng);
    //     //hien thi cua so thong tin
    //     infowindow.open(map,marker);
    // });
}

/* -------------------------------------------------------- 
   Scroll to top
   -------------------------------------------------------- */
   function scrollToTop(){
    $('.go-top').hide();
    // cuon len dau trang
    $('.btn-go-top').click(function(e) {
      e.preventDefault();
      var height = $(window).scrollTop();
      if(height > 0){
        $('html, body').animate({ scrollTop: 0 }, "slow");
      }
      return false;
    });


    //An nut scroll to top khi o tren dau trang
    $(window).scroll(function(){
      var height = $(window).scrollTop();
      if(height > 0){
        $('.go-top').show();
      } else {
        $('.go-top').hide();
      }
    });
   }

/* --------------------------------------------------------	
	 Truncate cac title tranh qua dai
   --------------------------------------------------------	*/
function truncateText(){
    $('.post-title-an').succinct({ size: 100 });
    $('.post-title').succinct({ size: 50 });
  //  $('.post-sm .post-info .post-title').succinct({size:90});
  //$('.post-lg .post-info .post-title').succinct({size:110});
  //$('.post-md .post-info .post-title').succinct({size:130});
  //$('.post-desc').succinct({size:160});
}

/* -------------------------------------------------------- 
   stick navbar header
   -------------------------------------------------------- */
function stickNavbar() {
  $(window).scroll(function(){
    if ($(this).scrollTop() > 200) {
      $('#mainnav').addClass("navbar-fixed-top animated slideInDown");
    }else{
      $('#mainnav').removeClass("navbar-fixed-top animated slideInDown");
    }
  });
}


