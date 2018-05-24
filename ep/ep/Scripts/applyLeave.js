var OriginalStatus;

$('input').focus(function () {
    var label = $("[for='" + $(this).attr('id') + "']");
    label.addClass('raised highlight');
})
$('input').blur(function () {
    var label = $("[for='" + $(this).attr('id') + "']");
    label.removeClass('highlight');
    if ($(this).val().length == 0) {
        label.removeClass('raised');
    } else {
        //Filter for password paramaters here
        if ($(this).attr("type") == "password") {
            if ($(this).val().length <= 3) {
                $(this).addClass('error');
                label.addClass('error');
                renderStatus("You password looks skrawny, beef it up.", 'error');
            } else {
                $(this).removeClass('error');
                label.removeClass('error');
                renderStatus(OriginalStatus);
            }
        }

        //Make sure the email address at least looks valid
        if ($(this).attr("type") == "email") {
            if ($(this).val().indexOf("@") > 0 && $(this).val().indexOf(".") > $(this).val().indexOf("@")) {
                $(this).removeClass('error');
                label.removeClass('error');
                renderStatus(OriginalStatus);
            } else {
                $(this).addClass('error');
                label.addClass('error');
                renderStatus("You sure that's a valid email?", 'error');
            }
        }

        //THE CODE HERE WILL BREAK IF YOU COPY AND PASTE IT WITHOUT 
        //COPYING AND PASTING THE ASSOCIATED ELEMENTS.

        //Check to see that your confirmation buddies are the same
        if ($(this).attr("id") == "cemail") {
            if ($('#cemail').val() != $('#email').val()) {
                $('#cemail').addClass('error');
                label.addClass('error');
                $('#email').addClass('error');
                $("[for='email']").addClass('error');
                renderStatus("You'd let your twins be different?", 'error');
            } else {
                $('#cemail').removeClass('error');
                label.removeClass('error');
                $('#email').removeClass('error');
                $("[for='email']").removeClass('error');
                renderStatus(OriginalStatus);
            }
        }
    }

    //I like the style of the status returning to normal if you fix one of your errors, 
    //while you have more then one error, but if you don't, just add a sanity check here.

})

$('select').focus(function () {
    var label = $("[for='" + $(this).attr('id') + "']");
    label.addClass('raised highlight');
})

$('select').blur(function () {
    var label = $("[for='" + $(this).attr('id') + "']");
    label.removeClass('highlight');
    if ($(this).val().length == 0) {
        label.removeClass('raised');
    }
})

$('select').change(function () {
    var label = $("[for='" + $(this).attr('id') + "']");
    label.removeClass('highlight');
    if ($(this).val().length == 0) {
        label.removeClass('raised');
    } else {
        label.addClass('raised highlight');
    }
})

//Lets filter some inputs
$('input').keydown(function (e) {
    if ($(this).attr("type") != "number")
        return;

    if ($.inArray(e.keyCode, [46, 8, 27, 13, 110]) !== -1 ||
        (e.keyCode == 65 && e.ctrlKey === true) ||
        (e.keyCode == 67 && e.ctrlKey === true) ||
        (e.keyCode == 88 && e.ctrlKey === true) ||
        (e.keyCode >= 35 && e.keyCode <= 39)) {
        return;
    }
    if ($(this).val().length >= 10)
        e.preventDefault();

    if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
        e.preventDefault();
    }
});

var StatusOldClass = "";
function renderStatus(status, classToAdd) {
    $("#Status").text(status);
    if (typeof StatusOldClass != "undefined" || StatusOldClass != "") {
        $("#Status").removeClass(StatusOldClass);
        StatusOldClass = classToAdd;
    }
    if (typeof classToAdd != "undefined") {
        $("#Status").addClass(classToAdd);
    }
}

function isFormValid() {
    //Call this from a button or whatever to double check that the form is valid before proceeding.

    //Not going to code this as it changes for each person's use
    //but it'll bascially look that same as input.blur()'s checks



    return true; //seemed like a good thing to add,     don't judge me.
}

$(document).ready(function () {
    OriginalStatus = $("#Status").text();
});

