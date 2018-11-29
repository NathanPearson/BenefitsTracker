var numDep = 0;
var depDisplayed = 6;
$(document).ready(function () {
    if ($("input[name='HasDependents']").is(':checked')) {
        while (depDisplayed < numDep) {
            showDependent(numDep);
        }
    } else {
        while (depDisplayed > numDep) {
            showDependent(numDep);
        }
    }
    //if has dependents is checked show add dependents
    $("input[name='HasDependents']").on("change", function () {
        if ($("input[name='HasDependents']").is(':checked')) {
            numDep = 1;
            $("#firstGroup").show();

        } else {
            $('#dependents').hide();
            $("input[name='FirstDependent']").val(null);
            $("input[name='SecondDependent']").val(null);
            $("input[name='ThirdDependent']").val(null);
            $("input[name='FourthDependent']").val(null);
            $("input[name='FifthDependent']").val(null);
            $("input[name='SixthDependent']").val(null);
        }
    });

    //on click add dependents
    $("#addDependents").on("click", function () {
        ++numDep;
        showDependent(numDep);
        if (numDep == 6) {
            $("#addDependents").hide();
        }
    });

    $("#removeDependents").on("click", function () {
        removeDependent(numDep);
        if (numDep == 0) {
            $("#removeDependents").hide();
        }
    });
});




function showDependent(i) {
    switch (i) {
        case 2:
            $("#secondGroup").show();
            break;
        case 3:
            $("#thirdGroup").show();
            break;
        case 4:
            $("#fourthGroup").show();
            break;
        case 5:
            $("#fifthGroup").show();
            break;
        case 6:
            $("#sixthGroup").show();
            break;
    }
    depDisplayed = i;
}

function removeDependent(j) {
    switch (j) {
        case 1:
            $('#firstGroup').hide();
            $('#firstGroup').val(null);
            $("input[name='HasDependents']").prop('checked', false);
            break;

        case 2:
            $('#secondGroup').hide();
            $('#secondGroup').val(null);
            break;
        case 3:
            $('#thirdGroup').hide();
            $('#thirdGroup').val(null);
            break;
        case 4:
            $('#fourthGroup').hide();
            $('#fourthGroup').val(null);
            break;
        case 5:
            $('#fifthGroup').hide();
            $('#fifthGroup').val(null);
            break;
        case 6:
            $('#sixthGroup').hide();
            $('#sixthGroup').val(null);
            break;
    }
    --numDep;
    depDisplayed = j;
}