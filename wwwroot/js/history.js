"use strict";

function clear(){
    console.log("MSG: NewGame");
    const lists = document.getElementsByClassName("historyList");
    for(let i=0,len=lists.length;i<len;i++){
        lists[i].innerHTML="";
    }
}

function getLetter(number){
    if(number <=15){
      return "B";
    }
    else if(number>15 && number <= 30){
      return "I";
    } 
    else if(number>30 && number <= 45){
      return "N";
    }
     else if(number>45 && number <= 60){
      return "G";
     }
     else if(number>60 && number <= 75){
      return "O";
     }
     return "";
  }

function numberCalled(number, status) {
    console.log(`MSG: NumberCalled ${number} - ${status}`);
    const letter = getLetter(number);
    const historyList = document.getElementById(`history-${letter}`);
    var li = document.createElement("li");
    li.classList.add("list-group-item");
    li.classList.add("history-item");
    li.innerHTML =`      
        <span class="history-letter history-letter-${letter}">${letter}</span> 
        <span class="history-value">${number}</span>
    `;
    historyList.appendChild(li);
}

connection.on("NewGame", clear);
connection.on("NumberCalled", numberCalled);


