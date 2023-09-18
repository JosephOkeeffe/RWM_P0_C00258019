public class FactFilter
{
    public static int fact(int x)
    {
        int factorial = x;

        while (x > 1)
        {
            factorial *= (x - 1);
            x--;
        }

        return factorial;
    }

    public static int[] fact(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = fact(xs[i]);
        }
        return result;
    }
}
