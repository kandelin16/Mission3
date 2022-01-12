$(document).on('click', '#calcumalationButton', function () {
    var assignmentsGrade = $("#assignmentsGrade").val();
    var projectGrade = $("#projectGrade").val();
    var quizzesGrade = $("#quizzesGrade").val();
    var examsGrade = $("#examsGrade").val();
    var intexGrade = $("#intexGrade").val();

    var letterGrade = ""
    var totalGrade = (
        assignmentsGrade * .55 +
        projectGrade * .05 +
        quizzesGrade * .10 +
        examsGrade * .20 +
        intexGrade * .10
    )

    totalGrade = Math.round(totalGrade)

    var letterGrade = getLetterGrade(totalGrade)

    $("#percentageGrade").html("Your number grade is: " + totalGrade.toString())
    $("#letterGrade").html("Your letter grade is: " + letterGrade)
    $("#percentageGrade").fadeIn("slow")
    $("#letterGrade").fadeIn("slow")
});

function getLetterGrade(totalGrade) {
    var letterGrade = ""
    if (totalGrade > 93) {
        letterGrade = "A"
    }
    else if (totalGrade > 90) {
        letterGrade = "A-"
    }
    else if (totalGrade > 87) {
        letterGrade = "B+"
    }
    else if (totalGrade > 83) {
        letterGrade = "B"
    }
    else if (totalGrade > 80) {
        letterGrade = "B-"
    }
    else if (totalGrade > 77) {
        letterGrade = "C+"
    }
    else if (totalGrade > 73) {
        letterGrade = "C"
    }
    else if (totalGrade > 70) {
        letterGrade = "C-"
    }
    else if (totalGrade > 67) {
        letterGrade = "D+"
    }
    else if (totalGrade > 63) {
        letterGrade = "D"
    }
    else if (totalGrade > 60) {
        letterGrade = "D-"
    }
    else {
        letterGrade = "E"
    }

    return letterGrade
}