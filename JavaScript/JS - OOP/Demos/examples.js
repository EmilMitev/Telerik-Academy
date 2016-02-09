function iterateList(listId) {
    var trainersList = document.getElementsById(listId);
    var parent = trainersList.parentNode;

    log("parent of trainers-list: " + parent.nodeName + " with id: " + parent.id);

    var children = trainersList.childNodes;

    log("elements in trainers-list: " + children.length);
    log("element in trainers-list");

    for (var i = 0, len = children.length; i < len; i += 1) {
        var subItem = children[i];
        log(subItem.nodeName + " content: " +
            subItem.innerText);
    }
}


/////////////////////////////////////////////////////////////////////////////////////////////////
//removing elements
var trainers = document.getElementsByTagName("ul")[0];
var trainer = trainers.getElementsByTagName("li")[0];
trainers.removeChild(trainer);

//remove a selected element
var selectedElement = //select the element
selectedElement.parentNode.removeChild(selectedElement);

////////////////////////////////////////////////////////////////////////
//fast add more elements faster than appendChild
var dFrag = document.createDocumentFragment();

dFrag.appendChild(div);

//appending more elements

document.body.appendChild(dFrag);

//////////////////////////////////////////////////////////////
//faster create element 
var clonedNode = someElement.cloneNode(true);

///////////////////////////////////////////
//check if is html element
var liElement = document.createElement("li");
console.log(liElement instanceof HTMLLIElement); //true
console.log(liElement instanceof HTMLElement); //true
console.log(liElement instanceof HTMLDivElement); //false