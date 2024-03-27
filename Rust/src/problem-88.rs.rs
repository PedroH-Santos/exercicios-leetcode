fn main() {
    let mut nums1: Vec<i32> = vec![2, 0];
    let mut nums2: Vec<i32> = vec![1];
    merge(&mut nums1, 1, &mut nums2, 1);
    println!("Array: {:?}", nums1);
}

pub fn merge(nums1: &mut Vec<i32>, m: i32, nums2: &mut Vec<i32>, n: i32) {
    nums1.truncate(m as usize);
    nums2.truncate(n as usize);
    nums1.append(nums2);
    nums1.sort();
}
