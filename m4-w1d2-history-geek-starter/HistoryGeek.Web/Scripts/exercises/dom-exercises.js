/// <reference path="../jquery-3.1.1.js" />
//Locate all <div> elements and add the 'president' class.
function presentialDivs() {
    //$("#presidents").addClass('president');
    //("div.#presidents").addClass('president');
    $("#presidents").children().filter("div").addClass('president');
}

//Locate George Washington and add the 'founding-father' class
function georgeWashington() {
    $("#george-washington").filter("div").addClass('founding-father');
}

//Locate all Republican presidents and add the 'red' class.
function republicanPresidents() {
    $(".Republican").filter("div").addClass('red');
}

//Locate all Democrat presidents and add the 'blue' class.
function democratPresidents() {
    $(".Democratic").filter("div").addClass('blue');

}

//Locate all Federalist presidents and add the 'gold' class.
function otherPresidents() {
    $("#presidents > div:not('.Democratic,.Republican')").addClass('gold');
    
}

//Locate all presidents named 'James' and add the 'james' class.
function presidentsNamedJames() {

    //var jameses = $("#presidents").children("div:contains('James')").addClass('james')
    //console.log(jameses);
    $('#presidents').children('div[id^=james]').addClass('james');

}

//Locate each president serving at the beginning of each century and add the 'beginningOfCentury' class.
function turnOfTheCenturyPresidents() {
    var beginCentury = $("#presidents").children("h2").next("div")
                            .addClass('beginningOfCentury'); 
    console.log(beginCentury);
}

//Locate each president serving at the end of the century and add the 'endOfCentury' class.
function endOfTheCenturyPresidents() {
    
    var theEndOfCentury = $("#presidents").children("h2").prev("div").addClass('endOfCentury');
    var trump = $("#presidents").children("div[id^=donald-trump]").addClass('endOfCentury');
    console.log(theEndOfCentury);
    console.log(trump);

}

//Locate all presidents serving in the 1900s who appear on currency and add the 'appearOnCurrency' class.
function currencyPresidents() {
    var pressOnCurrency = $("#presidents").children("h2:contains(1900)").nextUntil("h2").filter(".currency")
                                          .addClass('appearOnCurrency');
   
    console.log(pressOnCurrency);
  
}