function reverseStr()
{
    let input = document.getElementById("in-reverse").value;
    let temp = input.split("").reverse();
    let result = temp.join("");
    document.getElementById("out-reverse").value = result;
}
function palindromise()
{
    let input = document.getElementById("pal-in").value;
    input = input.toLowerCase().replace(/[\W]/g, "");
    let temp = input.split("").reverse().join("");
    document.getElementById("pal-out").value = (temp == input).toString();
}

function addToStr()
{
    let input = document.getElementById("string-in").value;
    var regex = new RegExp(/\d+$/);
    var digits = input.match(regex);
    var chars = input.replace(digits, "");
    if (digits == null)
    {
        digits = "1"
    }
    else
    {
        digits = (parseInt(digits)+1).toString();
    }
    document.getElementById("string-out").value = (chars + digits);
}