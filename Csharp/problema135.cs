public class Solution135
{
    public static int Candy(int[] ratings)
    {
        int[] candies = new int[ratings.Length];
        Array.Fill(candies,1);
        for (int i = 0; i < ratings.Length; i++)
        {
            //Console.WriteLine(ratings[i]);

            if (i - 1 >= 0)
            {
                if (ratings[i] > ratings[i - 1] && candies[i] <= candies[i - 1]  ) {
                    candies[i] += 1;
                   // Console.WriteLine("1");
                }
            }
            if (i + 1 < ratings.Length)
            {
                Console.WriteLine(candies[i + 1] + "\t" + candies[i]);
                if (ratings[i] > ratings[i + 1] && candies[i] <= candies[i + 1] )
                {
                    candies[i] += 1;
                   // Console.WriteLine("2");
                }
            }
            Console.WriteLine("-----------------------------");

        }

        Console.WriteLine(String.Join(",", candies));

        return candies.Sum();
    }


}