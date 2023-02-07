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

