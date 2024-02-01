
const a = uniqueOccurrences([1, 2]);
console.log(a);

interface auxObject {
    item: number,
    count: number,
}

function uniqueOccurrences(arr: number[]): boolean {
    var countsElements: auxObject[] = [];
    var result: boolean = true;
    arr.forEach(item => {
        if (!countsElements.find((itemFind) => itemFind.item == item)) {
            const countOfElementInArray = arr.filter((itemFind) => itemFind == item).length;
            const hasAlreadyThisCount = countsElements.find((itemFind) => itemFind.count === countOfElementInArray);
            if (hasAlreadyThisCount != undefined) {
                result =  false;
            } else {
                countsElements.push({
                    item: item,
                    count: countOfElementInArray,
                });

            }
        }
    })
    return result;
};