const array = [0,1,2,2,3,0,4,2];

const index = removeElement(array,2);

function removeElement(nums: number[], val: number): number {
    let countWithNotEqual = 0;
    for (let index = 0; index < nums.length; index++) {
        if(nums[index] != val) {
            console.log(nums[index]);
            nums[countWithNotEqual] = nums[index];
            countWithNotEqual++;
        }
        
    }
    return countWithNotEqual;

};