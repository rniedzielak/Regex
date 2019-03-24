function processData(input) {

    function scrapeMarkUp(regex) {

        var returnArray = [];

        while ((myArray = regex.exec(input)) != null)
            returnArray.push(myArray[1]);

        return returnArray;
    }

    var ids = scrapeMarkUp(/<h3><a href="\/questions\/(.+)\/.+-/g);
    var question = scrapeMarkUp(/class="question-hyperlink">(.+)<\/a><\/h3>/g);
    var time = scrapeMarkUp(/class="relativetime">(.+)<\/span>/g);

    for (var i = 0; i < ids.length; i++)
        console.log(ids[i] + ";" + question[i] + ";" + time[i]);

}  

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});
