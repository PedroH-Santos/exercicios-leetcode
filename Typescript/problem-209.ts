
minSubArrayLen(4, [1,4,4]);

function minSubArrayLen(target: number, nums: number[]): number {
    let current = 1;
    let start = 0;
    let sum = nums[start];
    let arrayNums: number[] = [];
    let lengthResult = 0;
    arrayNums.push(nums[start]);
    while (start < nums.length - 1) {
        console.log(sum);
        console.log(target);
        console.log('----------');
        if (sum == target) {
            if (lengthResult == 0 || arrayNums.length < lengthResult)
                lengthResult = arrayNums.length;


        }
        if (sum >= target || current == nums.length - 1) {
            start++;
            current = start + 1;
            sum = nums[start];
            arrayNums = [];
            arrayNums.push(nums[start]);

        } else {
            current++;
        }
        sum += nums[current];



    }
    console.log(lengthResult);
    return lengthResult;


};