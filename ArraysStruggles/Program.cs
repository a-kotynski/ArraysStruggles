namespace ArraysStruggles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seq = 5;
            //ReverseSeq(seq);
            //ReverseSeqWrite(seq);
            SeqWrite(seq);
            static int[] ReverseSeq(int n)
            {
                int[] array = new int[n];
                for (int i = n; i > 0; i--)
                {
                    array[i - 1] = i;
                }
                return array;
            }
            static void ReverseSeqWrite(int n)
            {
                int[] array = new int[n];
                for (int i = n; i > 0; i--)
                {
                    array[i - 1] = i;
                    Console.WriteLine($"Array {i - 1}: " + array[i - 1]);
                }
            }
            static void SeqWrite(int n)
            {
                int[] array = new int[n];
                for (int i = 1; i <= n; i++)
                {
                    array[i - 1] = n - i + 1;
                    Console.WriteLine($"Array {i - 1}: " + array[i - 1]);
                }
            }
        }
    }
}