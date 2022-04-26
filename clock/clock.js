//var overlay = document.getElementById('overlay');
//var base = document.getElementById('base');
var deg = 0;

var analog = document.getElementById('analog');
//var analogS = document.getElementById('analogS');
var analogSS = document.getElementById('analogScirc');
//var analogM = document.getElementById('analogM');
var analogMS = document.getElementById('analogMcirc');
//var analogH = document.getElementById('analogH');
var analogHS = document.getElementById('analogHcirc');

addTicks();

//var clockElement = document.getElementById('clock');
var time = new Date();
var hour = time.getHours();
hour = (hour >= 10) ? hour : "0" + hour;
var min = time.getMinutes();
min = (min >= 10) ? min : "0" + min;
var sec = time.getSeconds();
sec = (sec >= 10) ? sec : "0" + sec;

//clockElement.innerText = " " + hour + " : " + min + " : " + sec + " ";
//overlay.setAttribute("style", "min-width:" + base.offsetWidth + "px; min-height:" + base.offsetHeight + "px;");



function updateAnalog() {
    var calcDeg = sec * 6;
    analog.style.background = "linear-gradient(" + calcDeg + "deg, rgba(238,174,202,1) 0%, rgba(179,131,152,1) 2%, rgba(0,0,0,0) 4%, rgba(0,0,0,0) 100%);";
}


function addTicks() {
    for (var i = 0; i < 60; i++) {

        var noob = document.createElement("div");
        noob.setAttribute("id", "tick" + i);

        if (i % 5 == 0) {
            noob.setAttribute("class", "bigTick");
            noob.style.transform = "rotate(" + (i * -6) + "deg) translate(45%) scale(7%,0.5%) ";
        } else {
            noob.setAttribute("class", "tick");
            noob.style.transform = "rotate(" + (i * -6) + "deg) translate(45%) scale(3%,0.5%) ";
        }



        analog.append(noob);

    }


}

setInterval(function() {
        time = new Date();

        hour = time.getHours();
        min = time.getMinutes();
        sec = time.getSeconds();
        var ms = time.getMilliseconds();

        var h = ((hour > 12) ? hour - 12 : hour);
        //  console.log("h : " + h);
        var calcDegH = ((h + (min / 60) + (sec / 3600)) * 30) + 180;

        var calcDegM = ((min + (sec / 60) + (ms / 60000)) * 6) + 180; //+ (time.getMilliseconds() / 60000)
        var calcDegS = ((sec + (ms / 1000)) * 6) + 180; //

        //  console.log("H:" + hour + " " + calcDegH + "\nM:" + min + " " + calcDegM + "\nS:" + sec + " " + calcDegS);

        hour = (hour >= 10) ? hour : "0" + hour;
        min = (min >= 10) ? min : "0" + min;
        sec = (sec >= 10) ? sec : "0" + sec;

        //  analog.style.transform = "rotate(" + (calcDegS) + "deg)";

        //  clockElement.innerText = " " + hour + " : " + min + " : " + sec + " ";

        // var newCol = "linear-gradient(" + (calcDegS) + "deg, rgba(255,255,255,0) 49%, rgba(45,226,255,0.3) 49.5%, rgba(32,165,179,0.75) 50%, rgba(45,226,255,0.3) 50.5%, rgba(255,255,255,0) 51%)";
        // analogS.style.background = newCol;
        analogSS.style.transform = "rotate(" + (calcDegS) + "deg) scale(0.75%,45%) translate(50%,50%)";

        //    newCol = "linear-gradient(" + (calcDegM) + "deg, rgba(255,255,255,0) 49%, rgba(112,45,255,0.3) 49.5%, rgba(147,45,255,0.75) 50%, rgba(112,45,255,0.3) 50.5%, rgba(255,255,255,0) 51%)";
        //    analogM.style.background = newCol;
        analogMS.style.transform = "rotate(" + (calcDegM) + "deg) scale(1.5%,40%) translate(50%,50%) ";

        //    newCol = "linear-gradient(" + (calcDegH) + "deg, rgba(255,255,255,0) 49%, rgba(255,45,140,0.3) 49.5%, rgba(255,45,140,0.75) 50%, rgba(255,45,140,0.3) 50.5%, rgba(255,255,255,0) 51%)"
        //    analogH.style.background = newCol;
        analogHS.style.transform = "rotate(" + (calcDegH) + "deg) scale(1.5%,25%) translate(50%,50%) ";

        // 


    },
    100);

/*
setInterval(function() {
    overlay.style.background = "linear-gradient(" + deg + "deg, rgba(0, 0, 0, 0.24) 0%, rgba(183, 255, 178, 0.5) 47%, rgba(209, 255, 196, 0.5) 53%, rgba(0, 0, 0, 0.24) 100%)";
    deg = (deg > 360) ? 0 : deg + 1;
}, 100);*/