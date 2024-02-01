console.log(canConstruct("aa","aab"));
function canConstruct(ransomNote: string, magazine: string): boolean {
    const letters = new Map();

    for(const letter of magazine) {
        letters.set(letter,((letters.get(letter) || 0) + 1));
    }

    for(const letter of ransomNote) {
        if(!letters.get(letter)) {
            return false;
        }
        letters.set(letter,letters.get(letter) - 1);
    }
    return true;
};