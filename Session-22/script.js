function reverseStr()
{
    let input = document.getElementById("in-reverse").value;
    let temp = input.split("").reverse();
    let result = temp.join("");
    document.getElementById("out-reverse").value = result;
}
function checkPalindrome()
{
    let input = document.getElementById("pal-in").value;
    input = input.toLowerCase().replace(/[\W]/g, "");
    let temp = input.split("").reverse().join("");
    if (temp == input)
    {
        document.getElementById("pal-out").value = "Yes";
        document.getElementById("pal-out").style.backgroundColor="#90EE90"
    }
    else
    {
        document.getElementById("pal-out").value = "No";
        document.getElementById("pal-out").style.backgroundColor="#FFCCCB"
    }
}

function Inputs() {
    let a = document.getElementById("a").value;
    let b = document.getElementById("b").value;
    document.getElementById("output-multiply").value = multiply(a, b);

}


function multiply(a, b)
{
    return a*b;
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
