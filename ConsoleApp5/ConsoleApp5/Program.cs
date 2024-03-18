public class ConsoleApp5
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array is null or empty");
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        return (double)sum / numbers.Length;
    }

    public static int ArrayMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array is null or empty");
        }

        int maxNum = numbers[0];
        foreach (int num in numbers)
        {
            if (num > maxNum)
            {
                maxNum = num;
            }
        }

        return maxNum;
    }
    
    public static void Main(string[] args) 
    {
        int[] nums = { 1, 2, 3, 4, 5, 6};
        double average = CalculateAverage(nums);
        int maxNumber = ArrayMax(nums);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Max: " + maxNumber);
    }
}