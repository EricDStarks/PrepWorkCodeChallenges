using System;
class PrepWorkCodeChallenges
{
    static int ArrayMaxResult(int[] array, int n)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == n)
            {
                count++;
            }
        }

        return count * n;
    }

    static bool IsLeapYear(int year)
    {

        if (year % 4 == 0)
        {
            if (year % 100 == 0 && year % 400 != 0)
            {
                return false;
            }
            return true;
        }
        return false;
    }

    static bool IsPerfectSequence(int[] array)
    {
        int sum = 0;
        int product = 1;

        foreach (int val in array)
        {
            if (val < 0)
            {
                return false;
            }

            sum += val;
            product *= val;
        }

        return sum == product;
    }

    static int[] SumOfRows(int[,] multArray)
    {
        int[] rowSumArr = new int[multArray.GetLength(0)];

        for (int i = 0; i < multArray.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < multArray.GetLength(1); j++)
            {
                rowSum += multArray[i, j];
            }
            rowSumArr[i] = rowSum;
        }
        return rowSumArr;

    }
    static void Main()
    {
        // Code Challenge 1

        int[] maxResultArr = new int[5];

        Console.WriteLine("Enter 5 numbers (1-10)");

        for (int i = 0; i < maxResultArr.Length; i++)
        {

            maxResultArr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"now select one of your numbers [{maxResultArr[0]},{maxResultArr[1]},{maxResultArr[2]},{maxResultArr[3]},{maxResultArr[4]}]");

        int choice = Convert.ToInt32(Console.ReadLine());
        int result = ArrayMaxResult(maxResultArr, choice);

        Console.WriteLine($"Your score is {result}");

        // Code Challenge 2

        Console.WriteLine("enter a 4 digit year");
        int year = Convert.ToInt32(Console.ReadLine());
        bool isLeapYear = IsLeapYear(year);
        string jump = isLeapYear ? "is" : "is not";
        Console.WriteLine($"{year} {jump} a leap year");

        // Code Challenge 3
        Console.WriteLine("Problem 3 test");
        int[] perfectSeq = { 2, 1, 3 };
        int[] nonPerfectSeq = { 2, -2, 0 };
        Console.WriteLine("[2,1,3]");
        Console.WriteLine(IsPerfectSequence(perfectSeq));
        Console.WriteLine("[2, -2, 0]");
        Console.WriteLine(IsPerfectSequence(nonPerfectSeq));

        // Code Challenge 4

        Console.WriteLine("Problem 4 test row sums");
        int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
        int[] sumOfRows = SumOfRows(myArray);
        foreach (int sum in sumOfRows)
        {
            Console.WriteLine(sum);
        }
        Console.ReadLine();
    }

}