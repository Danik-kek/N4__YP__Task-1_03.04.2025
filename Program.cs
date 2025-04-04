namespace N4__YP__Task_1_03._04._2025
{
    internal class Program
    {
        static void Main()
        {

            int j = 2;
            for (int i = 2; i < 32; i = i * 2)
            {
                while (i < j)
                {
                    j = j * 2;
                }
                i = j - i;
            }

        }
    }
}
