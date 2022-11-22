"use strict";



var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();



connection.on("ReceiveMessage", function (number, status) {
    let id=`number-${number}`
    let cell=document.getElementById(id);
    let selectedClass="selected";
    let on=status == "true";
    if(cell.classList.contains(selectedClass)){
        cell.classList.remove(selectedClass);
    }
    else{
        cell.classList.add(selectedClass);
        on=true;
    }
});

connection.on("NewGame", function () {
    let selectedNumbers=document.getElementsByTagName("td");
    for(let i=0;i<selectedNumbers.length;i++){
        selectedNumbers[i].classList.remove("selected");
    }
});

connection.start().then(function () {
    console.log("connected")
}).catch(function (err) {
    return console.error(err.toString());
});


function numberClick(num){
    let id=`number-${num}`
    let selectedClass="selected";
    let cell=document.getElementById(id);
    let on=false;
    if(cell.classList.contains(selectedClass)){
        cell.classList.remove(selectedClass);
    }
    else{
        cell.classList.add(selectedClass);
        on=true;
    }

    connection.invoke("SendMessage", num.toString(), on.toString()).catch(function (err) {
        return console.error(err.toString());
    });
}