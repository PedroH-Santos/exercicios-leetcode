/**
 Do not return anything, modify nums1 in-place instead.
 */
merge([1,2,3,0,0,0],3,[2,5,6],3);
 function merge(nums1: number[], m: number, nums2: number[], n: number): void {
    let array = nums1.filter((item) => item != 0);
    array = [...array,...nums2].sort();
    nums1.forEach(val => array.push(Object.assign({}, val)));
    console.log(nums1);
};