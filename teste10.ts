wordPattern("abba", "dog cat cat fish");

function wordPattern(pattern: string, s: string): boolean {
    const characters = new Map();
    const wordsMap = new Map();
    const words = s.split(" ");

    if (pattern.length !== words.length) return false;

    for (let i = 0; i < pattern.length; i++) {
        if (!characters.has(pattern[i])) {
            characters.set(pattern[i], i);
        }
        if (!wordsMap.has(words[i])) {
            wordsMap.set(words[i], i);
        }
    }

    for (let i = 0; i < words.length; i++) {

        if (wordsMap.get(words[i]) !== characters.get(pattern[i])) {
            return false;
        }
    }
    return true;

};