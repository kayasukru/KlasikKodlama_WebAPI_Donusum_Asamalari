internal class Program
{
    private static void Main(string[] args)
    {
        int[] s1 = { 1, 2, 3, 4, 5 };
        int[] s2 = { 10, 20, 30, 40, 50, 60, 70 };

        int t1 = 0;
        int t2 = 0;

        for (int i = 0; i < s1.Length; i++)
        {
            t1 += s1[1];
        }

        for (int i = 0; i < s2.Length; i++)
        {
            t2 += s2[i];
        }

        Console.WriteLine("Birinci Dizi Sayıları Toplamı: " + t1);
        Console.WriteLine("İkinci Dizi Sayıları Toplamı: " + t2);
    }
}