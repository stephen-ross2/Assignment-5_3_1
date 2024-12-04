namespace Assignment_5_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the current flowerbed layout to determine if more flowers can be planted without adjacent flower plots (e.g., 1,0,0,0,1): ");
            string userFlowerBed = Console.ReadLine();

            int[] flowerbed = Array.ConvertAll(userFlowerBed.Split(','), int.Parse);

            int maxFlowers = MaxFlowers(flowerbed);

            Console.WriteLine($"The maximum number of additional flowers that can be planted in your bed is: {maxFlowers}");
        }

        public static int MaxFlowers(int[] flowerbed)
        {
            int count = 0;
            int length = flowerbed.Length;

            for (int i = 0; i < length; i++)
            {

                if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == length - 1 || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1;
                    count++;
                }
            }

            return count;
        }
    }
}
