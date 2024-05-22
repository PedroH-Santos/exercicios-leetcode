public class SolutionAma4
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int l3 = nums1.Length + nums2.Length;
        int[] numsMerge = new int[l3];
        int mid = numsMerge.Length / 2;
        int countN1 = 0;
        int countN2 = 0;
        Console.WriteLine(nums1.Length + "\t" +  nums2.Length);
        for (int i = 0; i <= mid; i++)
        {
            int n1 = countN1 < nums1.Length ? nums1[countN1] : 500000000;
            int n2 = countN2 < nums2.Length ? nums2[countN2] : 500000000;
            int newNum = Math.Min(n1, n2);
            if (newNum == n1) {
                countN1++;
            }else{
                countN2++;
            }
            numsMerge[i] = newNum;
        }
        Console.WriteLine(String.Join(",", numsMerge));
        if (numsMerge.Length % 2 == 0)
        {
            return (numsMerge[mid - 1] + numsMerge[mid]) / 2.0;
        }
        else
        {
            return numsMerge[mid];
        }
    }
} 