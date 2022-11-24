"use strict";

function clearBoard(){
    console.log("MSG: NewGame");
    let numbers=document.getElementsByClassName("number");
    for(let i=0;i<numbers.length;i++){
        numbers[i].classList.remove("selected");
    }
}

function numberCalled(number, status) {
    console.log(`MSG: NumberCalled ${number} - ${status}`);
    let id=`number-${number}`
    let cell=document.getElementById(id);
    let selectedClass="selected";
    if(status.toLowerCase() == "true"){
        cell.classList.remove(selectedClass);
    }
    else{
        cell.classList.add(selectedClass);
    }
}

connection.on("NewGame", clearBoard);
connection.on("NumberCalled", numberCalled);


