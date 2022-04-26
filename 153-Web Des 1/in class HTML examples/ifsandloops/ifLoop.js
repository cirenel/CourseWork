document.write("<div id='diceRolls'>");
for (var i = 0; i < 10; i++) {
    var win = Math.random();
    if (win >= 0.9) {
        document.write("<div><h3>you won </h3><h5>" + win + "</h5></div>");
    } else {
        document.write("<div><h3>ya lost </h3><h5>" + win + "</h5></div>");
    }
}
document.write("</div>");

document.write("<div id='names'>");
var arr = ["mason", "jesse", "hayden", "peyton", "noah", "alex"];
for (var j = 0; j < arr.length; j++) {

    //uses the variable j as an index to get an array value
    var currentName = arr[j];
    document.write("<h2>Hello, " + currentName + "!</h2>");

}
document.write("</div>");

document.write("<div id='names' style='text-align:right;'>");
var greet = ["hello", "hei", "hola", "guten tag", "sup", "bonjour"];
for (var j = 0; j < arr.length; j++) {

    //uses the variable j as an index to get an array value
    var currentName = arr[j];
    var rand = Math.floor(arr.length * Math.random());
    document.write("<h2>" + greet[rand] + ", " + currentName + "!</h2>");

}
document.write("</div>");

document.write("<div id='while'>");
var won = false;
var count = 0;
while (!won) { //OR while( won == false )
    var num = Math.random();
    count++;
    if (num >= 0.9) {
        document.write("<div><h3>you won </h3><h5>" + num + "</h5></div>");
        won = true;
    } else {
        document.write("<div><h3>ya lost </h3><h5>" + num + "</h5></div>");
    }
}
document.write("<div>It took " + count + " tries. </div>")
document.write("</div>");

var element = document.getElementById('banner');

if (element == null) {
    document.write("<h3 id='banner'>THIS IS A BANNER</h3>");
}