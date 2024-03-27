
maxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);

function maxArea(height: number[]): number {
    let right = height.length - 1;
    let left = 0;
    let maxVolume = -1;

    while (left < right) {
        let minHeight = Math.min(height[right], height[left]);
        let volume = minHeight * (right - left);
        if (volume > maxVolume) {
            maxVolume = volume;
        }
        if (height[left] > height[right]) {
            right--;
        } else {
            left++;
        }

    }
    return maxVolume;
};

