isPalindrome("A man, a plan, a canal: Panama");
function isPalindrome(s: string): boolean {
    const traitString = s.replace(/\s/g, "").replace(/[^a-zA-Z0-9]/g, "").toLowerCase();
    for (let i = 0, j = traitString.length - 1; i < j;i++,j--) {
        if(traitString[i] != traitString[j]){
            return false;
        }

    }
    return true;
};