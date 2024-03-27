

function summaryRanges(nums: number[]): string[] {
    let intervals: string[] = [];
    if (nums.length != 0) {
        let start = nums[0];
        let end = 0;
        for (let i = 0; i < nums.length; i++) {
            if (nums[i + 1] == undefined) {
                if (start != nums[i]) {
                    intervals.push(start + "->" + end);

                } else {
                    intervals.push(start.toString());

                }
            } else if (nums[i] + 1 == nums[i + 1]) {
                end = nums[i + 1];
            } else {
                intervals.push((end != 0) ? start.toString() + "->" + end.toString() : start.toString());
                start = nums[i + 1];
                end = 0;
            }

        }
    }
    return intervals;


};