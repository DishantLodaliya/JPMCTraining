namespace HandsOnArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            a[0] = 41;
            a[1] = 52;
            a[2] = 63;
            a[3] = 74;
            a[4] = 85;

            foreach (int i in a)
                Console.WriteLine(i);
            int[] newCopy = new int[5];
            Array.Copy(a, newCopy, 5);
            foreach (int i in newCopy)
                Console.WriteLine(i);

        }
    }
}