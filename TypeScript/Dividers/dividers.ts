export default function dividers(number: number): void 
{
    let numCount, numDiv = 0;
    numDiv = number;
    while (numDiv > 0) {
        numCount = number % numDiv;
        if (numCount == 0) {
            console.log(numDiv);
        }
        numDiv--;
    }
    return;
}
