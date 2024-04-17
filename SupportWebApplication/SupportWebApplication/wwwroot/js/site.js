// Function to update table row styles

function updateRowStyles() {

    var rows = document.querySelectorAll("#appealsTable tbody tr");

    rows.forEach(function (row) {

        var deadline = new Date(row.cells[2].innerText); //Getting the deadline date and time from a cell

        var timeRemaining = (deadline - new Date()) / (1000 * 3600); // Remaining time in hours

        if (timeRemaining < 1) {

            row.style.color = "red";

        } else {

            row.style.color = "";

        }

    });

}



setInterval(updateRowStyles, 60000); // Update 1 min
