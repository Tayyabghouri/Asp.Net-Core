// $(document).ready(function()
        // {
        //     $('[data-toggle="tooltip"]').tooltip();
        // });
        $(document).ready(function()
        {
            $('#mycarousel').carousel({interval:2000});
            $("#carouselButton").click(function()
            {
                if ($("#carouselButton").children("span").hasClass('fa-pause')) {
                    $("#mycarousel").carousel('pause');
                    $("#carouselButton").children("span").removeClass('fa-pause');
                    $("#carouselButton").children("span").addClass('fa-play');
                }
                else if ($("#carouselButton").children("span").hasClass('fa-play')){
               
                    $("#mycarousel").carousel('cycle');
                    $("#carouselButton").children("span").removeClass('fa-play');
                    $("#carouselButton").children("span").addClass('fa-pause');  
                }

            });
            // $("#carouselButton").click(function(){
            //     if ($("#carouselButton").children("span").hasClass('fa-pause')) {
            //         $("#mycarousel").carousel('pause');
            //         $("#carouselButton").children("span").removeClass('fa-pause');
            //         $("#carouselButton").children("span").addClass('fa-play');
            //     }
            //     else if ($("#carouselButton").children("span").hasClass('fa-play')){
            //         $("#mycarousel").carousel('cycle');
            //         $("#carouselButton").children("span").removeClass('fa-play');
            //         $("#carouselButton").children("span").addClass('fa-pause');                    
            //     }
            // });



            // $('#caurosel-pause').click(function()
            // {
            //     $('#mycarousel').carousel('pause');
            // });
            // $('#caurosel-play').click(function()
            // {
            //     $('#mycarousel').carousel('cycle');
            // });

$("#reservemodalbtn").click(function()
{
    $("#formModal").modal('toggle');
});

        //   login modal
            $("#loginbtn").click(function()
            {
                $("#loginModal").modal('toggle');
            });
        });