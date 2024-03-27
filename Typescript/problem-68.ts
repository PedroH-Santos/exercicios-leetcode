
fullJustify(["Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do"], 20);
function fullJustify(words: string[], maxWidth: number): string[] {
    let phrases: string[] = [];
    let countChars = 0;
    let phrase = '';
    for (let i = 0; i < words.length; i++) {
        countChars += words[i].length;


        console.log(phrase);
        console.log("Quantidade de chars: " + countChars);
        console.log(words[i]);

        if (countChars + 1 < maxWidth) {
            console.log("Caiu 1 ");
            phrase += words[i] + ' ';
            countChars++;
            if (i == words.length - 1) {
                phrases.push(phrase.trim());
            }
        } else if (countChars  <= maxWidth && phrase.split(' ').length == 1){
            console.log("Caiu 2 ");
            phrase += words[i];
            phrases.push(phrase.trim());
            phrase = '';
            countChars = 0;

        }else {
            phrases.push(phrase.trim());
            console.log("Caiu 3 ");
            countChars = words[i].length;
            phrase = words[i] + ' ';
            if (i == words.length - 1) {
                phrases.push(words[i].trim());
            }
        }

        console.log('--------------------------------');

    }
    console.log(phrases);

    let countExtraSpaces = 0;
    for (let i = 0; i < phrases.length; i++) {
        words = phrases[i].split(' ');
        countExtraSpaces = (maxWidth - phrases[i].length);
        console.log(countExtraSpaces);
        let currentWord = 0;
        for (let j = 0; j < countExtraSpaces; j++) {
            if (i == phrases.length - 1) {
                words[words.length - 1] += ' ';
            } else {

                if (currentWord >= words.length - 1) {
                    currentWord = 0;
                }
                words[currentWord] += ' ';
                currentWord++;
            }
        }
        phrases[i] = words.join(' ');
    }

    return phrases;
};