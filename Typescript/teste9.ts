
containsNearbyDuplicate([1, 2, 3, 1], 3);

function containsNearbyDuplicate(nums: number[], k: number): boolean {
    const numbers = new Map();

    for (let i = 0; i < nums.length; i++) {
        if (numbers.has(nums[i]) && numbers.get(Math.abs(nums[i] - i)) <= k) {
            return true;
        } else {
            numbers.set(nums[i], i)
        }
    }
    return false;
};