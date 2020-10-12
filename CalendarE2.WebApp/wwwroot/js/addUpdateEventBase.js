function aUEvent(elem, packForm, checkUpdate) {
    // sets up / shows modal for add / update
    // get hour from the click event to send with form submission which is declared in the AddUpdateModal View Component. 
    // The AddUpdateModal ViewComponent works for either Day or Week functionlity and allows for easy extension, for instance 
    // to Month mode, if desired.
    let hour = elem.getAttribute("data-hour");
    let hourNumb = parseInt(hour, 10);
    let datePieces = elem.getAttribute('data-datet').substr(0, 13).split("/");
    document.getElementById("modalHr").value = hourNumb;
    document.getElementById("displayHr").value = hour;
    let subjectMo = datePieces[0];
    let subjectDate = new Date(datePieces[2], subjectMo, datePieces[1], hourNumb);
    // month is one more than expected for for comparison purposes
    let compareDate = new Date(datePieces[2], subjectMo - 1, datePieces[1], hourNumb);
    let currDate = new Date();    
    //console.log("subjectDate ");
    //console.dir(subjectDate)
    //console.log("currDate ");
    //console.dir(currDate);
    // Check that the user is adding or updating only current or future times. No editing of past events    
    if (compareDate > currDate) {
        let tFrameElem = document.getElementById("timeFrameWeek").checked ? "2" : "1";
        packForm(subjectDate, tFrameElem);

        // get hour from the click event to send with form submission
        // Adjust for difference between add and update mode, fill form with current values, change modal title and submit button
        checkUpdate(elem);

        // show the Add or Updated modal based on whether the model has an event for the timeslot                
        $("#aUModal").modal('show');
    }
    else {
        $("#pastEventMessage").modal('show');
    }
};

function packForm(subjectDate, initTFElem) {
    // fill out form above so we can communicate with the backend with either a create or update
    document.getElementById("modalYr").value = subjectDate.getFullYear();
    document.getElementById("modalMo").value = subjectDate.getMonth();
    document.getElementById("modalDy").value = subjectDate.getDate();
    document.getElementById("modalTimeFrame").value = initTFElem;
};