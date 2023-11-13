using System.ComponentModel.DataAnnotations;

class program
{
    static float Average(int [] mas)
    {
        int max = mas[0];
        foreach (int i in mas)
        {
            max = max > i ? max : i;
        }
        return max;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Input number");
        int N = int.Parse(Console.ReadLine());
        int[] mas = new int[N];
        for (int i=0; i < N; i++)
        {
            mas[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(Average(mas));
    }
}