public class ConsoleApp5
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array is null or empty");
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return (double)sum / numbers.Length;
    } 
    
    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(nums);
        Console.WriteLine("Average: " + average);
    }
}