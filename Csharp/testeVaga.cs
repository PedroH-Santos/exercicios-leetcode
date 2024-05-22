
public class SolutionTeste
{
    public static int TotalMoedasGavetaMagica(int[] arr)
    {

        int moedas = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i] > 0) {
                moedas += arr[i];

            }
            else if(arr[i] < 0) {
                moedas = Math.Max(0,arr[i] + moedas - 1);

            }
            moedas *= 2;
        }
        return moedas;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(TotalMoedasGavetaMagica([1,-2,2,0,4]));
    }
}
