function PrintName()
{
    document.getElementById("test").innerHTML = "test";

    i = 0;

    document.getElementById("test").addEventListener('mouseover', function () {
        if (i < 5) {
           
            $("#test").animate({ left:  '+=250px', });
            i++;

        }
        else {
            i = 0;
            $("#test").css("left", "0");
        }
        
    });
}





