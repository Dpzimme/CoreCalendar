$(document).ready(function () {

    let dayTFElem = document.getElementById("timeFrameDay");
    let weekTFElem = document.getElementById("timeFrameWeek");
    let initTFElement = document.getElementById("initTimeFrame");

    if (initTFElement.value == "2") {
        weekTFElem.checked = true
    };
    dayTFElem.addEventListener("click", function dayClicked() {
        weekTFElem.checked = false;
        dayTFElem.checked = true;
    });
    document.getElementById("timeFrameWeek").addEventListener("click", function weekClicked() {
        dayTFElem.checked = false;
        weekTFElem.checked = true;
    });

    if (dayTFElem.checked == false && weekTFElem.checked == false) { dayTFElem.checked = true; }


    let dateEl = $('#datetimepicker12').datepicker({
        inline: true,
        sideBySide: true,
        autoSize: true,
        defaultDate: document.getElementById("initMo").value + "/" + document.getElementById("initDay").value + "/" + document.getElementById("initYr").value,
        onSelect: function (dateText, inst) {
            let dateAsObject = $(this).datepicker('getDate');
            let newYr = dateAsObject.getFullYear();
            let newMo = dateAsObject.getMonth() + 1;
            let newDay = dateAsObject.getDate();
            let timeFrame = dayTFElem.checked ? 1 : 2;
            let numbDays = 1;
            var fullUrl = "";
            // let baseUrlDay = "http://localhost:52225/home/NewDay?theYr=";
            //let baseUrlWeek = "http://localhost:52225/home/NewWeek?theYr=";
            let baseUrlDay = "https://ftpcalendare2.azurewebsites.net/home/NewDay?theYr=";
            let baseUrlWeek = "https://ftpcalendare2.azurewebsites.net//home/NewWeek?theYr=";
            if (timeFrame == 1) {
                //fullUrl = "http://localhost:52225/home/NewDay?theYr=" + newYr + "&theMo=" + newMo + "&theDay=" + newDay;
                fullUrl = baseUrlDay + newYr + "&theMo=" + newMo + "&theDay=" + newDay;
            }
            else {
                if (timeFrame == 2) {
                    //fullUrl = "http://localhost:52225/home/NewWeek?theYr=" + newYr + "&theMo=" + newMo + "&theDay=" + newDay;
                    fullUrl = baseUrlWeek + newYr + "&theMo=" + newMo + "&theDay=" + newDay; 
                }
                else {
                    console.log("Invalid TimeFrame, not 1, 2 or 3. going with day time frame");
                    //fullUrl = "http://localhost:52225/home/NewDay?theYr=" + newYr + "&theMo=" + newMo + "&theDay=" + newDay;
                    fullUrl = baseUrlDay + newYr + "&theMo=" + newMo + "&theDay=" + newDay;
                }
            };
            //$(".rightside").load(fullUrl);
            $.post(fullUrl, function (data) {
                $(".rightside").html(data);
            })
        }
    });

    function aUEvent(elem, packForm, ifUpdate) {
        // sets up / shows modal for add / update
        // get hour from the click event to send with form submission            
        let hour = elem.getAttribute("data-hour");
        let hourNumb = parseInt(hour, 10);
        let datePieces = elem.getAttribute('data-datet').substr(0, 13).split("/");
        document.getElementById("modalHr").value = hourNumb;
        document.getElementById("displayHr").value = hour;
        let subjectMo = datePieces[0] - 1;
        let subjectDate = new Date(datePieces[2], subjectMo, datePieces[1], hourNumb);
        let currDate = new Date();
        if (subjectDate > currDate) {
            firstClickFlag = true;
            packForm();

            // get hour from the click event to send with form submission
            // Adjust for difference between add and update mode, fill form with current values, change modal title and submit button
            ifUpdate();

            // show the Add or Updated modal based on whether the model has an event for the timeslot                
            $("#aUModal").modal('show');
        }
        else {
            $("#pastEventMessage").modal('show');
        }
    };
});

