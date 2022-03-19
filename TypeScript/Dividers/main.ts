import dividers from "./dividers";

(function ()
    {
        var stdin = process.openStdin();

        let number: number = 0;

        stdin.addListener("data", function(number){
            number = parseInt(number.toString().trim());
            dividers(number);
        });
    } 
)();