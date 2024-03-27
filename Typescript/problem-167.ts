twoSum([2, 7, 11, 15],9);

function twoSum(numbers: number[], target: number): number[] {
    let right = numbers.length - 1;
    let left = 0;
    let result: number[] = [];
    while(left < right) {
        const sum = numbers[left] + numbers[right];
        if(sum === target) {
            result.push(left + 1);
            result.push(right + 1);
            break;
        } else if(sum < target) {
            left++;
        } else {
            right--;
        }
    }
    console.log(result);
    return result;

};

