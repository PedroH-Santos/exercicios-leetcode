function isSubsequence(s: string, t: string): boolean {
    let countCharFinder = 0;
    for (let i = 0; i < t.length; i++) {
        if(s[countCharFinder] == t[i]) {
            countCharFinder++;
        }
    }

    return (s.length === countCharFinder)
};