romanToInt("MCMXCIV");

function romanToInt(s: string): number {
    const arrayRoman: { [key: string]: number } = {
        I: 1,
        V: 5,
        X: 10,
        L: 50,
        C: 100,
        D: 500,
        M: 1000
    }
    let currentNumber = 0;
    for (let i = 0; i < s.length; i++) {
        const firstElement = arrayRoman[s[i]];
        let secondElement = arrayRoman[s[i+1]];

        if(firstElement < secondElement) {
            currentNumber -= firstElement;
        }else{
            currentNumber += firstElement;
        }
        console.log(firstElement);
        console.log(secondElement);
        console.log(currentNumber);
        console.log("-----------");

    }


    console.log(currentNumber);
    return parseInt(currentNumber.toString());
};