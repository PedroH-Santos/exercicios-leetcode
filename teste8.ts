twoSum([1,3,4,2],6);
function twoSum(nums: number[], target: number): number[] {
    const numbers = new Map();

    for(let i = 0; i < nums.length; i++) {
        numbers.set(nums[i],i);
    }
    let response: number[] = [];
    for(let i = 0; i < nums.length; i++) {
        let sum = target - nums[i];
        let hasInMap = numbers.get(sum);
        if(hasInMap && hasInMap != i) {
            response.push(i);
            response.push(hasInMap);
            break;
        }
        
    }
    return response;
};