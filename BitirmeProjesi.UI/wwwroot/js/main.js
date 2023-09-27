(function ($) {
    "use strict";
    
    // Dropdown on mouse hover
    $(document).ready(function () {
        function toggleNavbarMethod() {
            if ($(window).width() > 992) {
                $('.navbar .dropdown').on('mouseover', function () {
                    $('.dropdown-toggle', this).trigger('click');
                }).on('mouseout', function () {
                    $('.dropdown-toggle', this).trigger('click').blur();
                });
            } else {
                $('.navbar .dropdown').off('mouseover').off('mouseout');
            }
        }
        toggleNavbarMethod();
        $(window).resize(toggleNavbarMethod);
    });
    
    
    // Back to top button
    $(window).scroll(function () {
        if ($(this).scrollTop() > 100) {
            $('.back-to-top').fadeIn('slow');
        } else {
            $('.back-to-top').fadeOut('slow');
        }
    });
    $('.back-to-top').click(function () {
        $('html, body').animate({scrollTop: 0}, 1500, 'easeInOutExpo');
        return false;
    });


    // Vendor carousel
    $('.vendor-carousel').owlCarousel({
        loop: true,
        margin: 29,
        nav: false,
        autoplay: true,
        smartSpeed: 1000,
        responsive: {
            0:{
                items:2
            },
            576:{
                items:3
            },
            768:{
                items:4
            },
            992:{
                items:5
            },
            1200:{
                items:6
            }
        }
    });


    // Related carousel
    $('.related-carousel').owlCarousel({
        loop: true,
        margin: 29,
        nav: false,
        autoplay: true,
        smartSpeed: 1000,
        responsive: {
            0:{
                items:1
            },
            576:{
                items:2
            },
            768:{
                items:3
            },
            992:{
                items:4
            }
        }
    });


    // Product Quantity
    $('.quantity button').on('click', function () {
        var button = $(this);
        var oldValue = button.parent().parent().find('input').val();
        if (button.hasClass('btn-plus')) {
            var newVal = parseFloat(oldValue) + 1;
        } else {
            if (oldValue > 0) {
                var newVal = parseFloat(oldValue) - 1;
            } else {
                newVal = 0;
            }
        }
        button.parent().parent().find('input').val(newVal);
    });

    getCartCunt();
    
})(jQuery);

function getCartCunt() {
    $.ajax({
        type: "GET",
        url: "/sepet/sepetsayisi",
        success: function (data) {
            $(".badge").text(data)
        },
        error: function (e) {
            alert(e.ResponseText)
        }
    });
}





function addCart(productid, stock) {
    var istenilenMiktar = $(".inputQuantity").val();
    if (istenilenMiktar <= stock) {
        $.ajax({
            type: "POST",
            url: "/sepet/sepeteekle",
            data: { "productid": productid, "quantity": istenilenMiktar },
            success: function (data) {
                if (data.indexOf("~") == -1) {
                    $("#modalSepet .modal-body").text(data + " urununden " + istenilenMiktar + " adet sepete basari ile eklendi...")
                    $("#modalSepet").modal('show');
                    getCartCunt()
                }
            },
            error: function (e) {
                alert(e.ResponseText)
            }
        });
    } else if (stock == 0) alert("Bu urun stoklarimizda bulunmamaktadýr...")
    else alert("Bu urunden en fazla " + stock + " adet siparis verebilirsiniz...")
}

function checkOutControl() {
    var mesaj = "";
    if ($(".selectPaymentOption").val() == "") mesaj = "Lutfen bir odeme secenegi belirtiniz"

    if (mesaj != "") {
        alert(mesaj)
        return false;
    }
}



function funcSelectPaymentOption(_obje) {
    var seciliOption = $(_obje).val();
    if (seciliOption != "") {
        $(".divPaymentOption").slideUp();
        switch (seciliOption) {
            case "1":
                $(".creditCard").slideDown();
                break;
            case "2":
                $(".bayyi").slideDown();
                break;
            default:
        }
    }
}

