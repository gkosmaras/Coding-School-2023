//Excercise 1
function reverseStr()
{
    let input = document.getElementById("in-reverse").value;
    let temp = input.split("").reverse();
    let result = temp.join("");
    document.getElementById("out-reverse").value = result;
}
//Excercise 2
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
//Excercise 3

let customers = [];

function saveCustomer()
{
    let name = document.getElementById('name').value;
    let surname = document.getElementById('surname').value;
    let age = document.getElementById('age').value;
    let gender = document.getElementById('gender').value;
    document.getElementById('name').value = "";
    document.getElementById('surname').value = "";
    document.getElementById('age').value = "";
    document.getElementById('gender').value = "";
    customers.push({ name, surname, age, gender });
    renderCustomers();
}

function renderCustomers()
{
    let customerTableBody = document.getElementById('customerTableBody');
    customerTableBody.innerHTML = '';
    customers.forEach(customer =>
    {
        let tr = document.createElement('tr');
        tr.innerHTML = `
      <td>${customer.name}</td>
      <td>${customer.surname}</td>
      <td>${customer.age}</td>
      <td>${customer.gender}</td>`;
        tr.addEventListener('click', () =>
        {
            renderCustomerDetails(customer);
        });
        customerTableBody.appendChild(tr);
    });
}

function renderCustomerDetails(customer)
{
    document.getElementById('name').value = customer.name;
    document.getElementById('surname').value = customer.surname;
    document.getElementById('age').value = customer.age;
    document.getElementById('gender').value = customer.gender;
}

//Excercise 4
function Inputs() 
{
    let a = document.getElementById("a").value;
    let b = document.getElementById("b").value;
    if(isNaN(a) || isNaN(b))
    {
        window.alert("Invalid input")
    }
    else
    {
        document.getElementById("output-multiply").value = multiply(a, b);
    }
}
function multiply(a, b)
{
    return a * b;
}
//Excercise 5
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
