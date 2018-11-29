
$(function () {    
    if ($("input[name='HasDependents']").is(':checked')) {
        $('#dependents').show();

    } else {
        $('#dependents').hide();
    }
    //if has dependents is checked show add dependents
    //TODO create functions to dynamically add and remove dependents
    $("input[name='HasDependents']").on("change", function () {
        if ($("input[name='HasDependents']").is(':checked')) {
            $('#dependents').show();

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


});