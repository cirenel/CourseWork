// Create a function to update the content of the element whose id attribute has a value of message
function updateMessage(msg) {
    var el = document.getElementById('message');
    var price = document.getElementById('bidPrice').innerText;
    el.innerText = msg + " Your total cost is: $" + calcPrice(price, 5);
}

function calcPrice(unitPrice, quantity) {
    var total = unitPrice * quantity;
    return total;
}

// Call the function
updateMessage('this is some text to display on the screen');

var area = function(w, h) { return w * h; };

var perim = (
    function(w, h) {
        return (w * 2) + (h * 2);
    }(7, 2)
);

console.log(area);
console.log(perim);
console.log(document);
console.log(screen);
console.log(window);
var s = "DANGER DANGER \n HIGH VOLTAGE";
window.alert(s);
console.log("char at index 7: " + s.charAt(7));
console.log("first H is at : " + s.indexOf('H'));
var n = 60000000000000 / 3;
console.log(n.toFixed(3));
console.log(n.toPrecision(3));
console.log(n.toExponential(3));

var v = 3 / 4;
console.log(Math.ceil(v));
console.log(Math.floor(v));

for (var i = 0; i < 10; i++) {
    console.log((10 * Math.random()) + 1);
}

var today = new Date();
console.log(today);