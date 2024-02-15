maxProfit([2,1,2,1,0,1,2]);

function maxProfit(prices: number[]): number {
    let lessValue = 99999;
    let higherValue = -1;
    let indexLess = 0;
    let indexHigher = 0;
    let result = 0;
    for (let i = 0; i < prices.length; i++) {
        if(prices[i] < lessValue) {
            indexLess = i;
            lessValue = prices[i];
            indexHigher = 0;
            higherValue = -1;
        }
        if(prices[i] > higherValue  && i > indexLess) {
            higherValue = prices[i];
            indexHigher = i;
            result = (higherValue - lessValue > result) ? higherValue - lessValue : result;
        }


    }
    return (result <= 0) ? 0 : result
};