namespace N4__YP__Task_1_03._04._2025
{
    internal class Program
    {
        static void Main()
        {

            double sum = 0;
            int count = 0;
            int.TryParse(Console.ReadLine(), out int A);

            while (true)
            {
                count++;                          // Увеличиваем счетчик слагаемых
                double term = Math.Pow(count, count); // Вычисляем текущее слагаемое n^n
                sum += term;                      // Добавляем его к сумме

                if (sum > A)
                { break; }
            }
            Console.WriteLine($"Количество слагаемых: {count}");
        }
    }
}
