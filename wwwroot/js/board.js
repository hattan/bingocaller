"use strict";

function clearBoard(){
    console.log("MSG: NewGame");
    let numbers=document.getElementsByClassName("number");
    for(let i=0;i<numbers.length;i++){
        numbers[i].classList.remove("selected");
        numbers[i].classList.remove("last");
    }
    let last=document.getElementById("last-called");
    last.innerHTML=``;
}

function clearLast(){
    let numbers=document.getElementsByClassName("number");
    for(let i=0;i<numbers.length;i++){
        numbers[i].classList.remove("last");
    }
}
function numberCalled(number, status) {
    console.log(`MSG: NumberCalled ${number} - ${status}`);
    let id=`number-${number}`
    let cell=document.getElementById(id);
    let selectedClass="selected";
    clearLast();
    if(status.toLowerCase() == "true"){
        cell.classList.remove(selectedClass);
        let last=document.getElementById("last-called");
        last.innerHTML=``;
    }
    else{
        cell.classList.add(selectedClass);
        cell.classList.add("last");
        let last=document.getElementById("last-called");
        last.innerHTML=`Last Number Called:  ${number}`;
    }


}

connection.on("NewGame", clearBoard);
connection.on("NumberCalled", numberCalled);


