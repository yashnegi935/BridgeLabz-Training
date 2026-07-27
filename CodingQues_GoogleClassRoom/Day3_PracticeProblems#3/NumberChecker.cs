namespace CalculatorProblems;

public class NumberChecker
{
    public static int CountDigits(int number)
    {
        int count = 0;
        int n = Math.Abs(number);
        if (n == 0) return 1;
        while (n > 0)
        {
            count++;
            n /= 10;
        }
        return count;
    }

    public static int[] StoreDigits(int number)
    {
        int count = CountDigits(number);
        int[] digits = new int[count];
        int n = Math.Abs(number);
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = n % 10;
            n /= 10;
        }
        return digits;
    }

    public static bool IsDuckNumber(int[] digits)
    {
        if (digits.Length == 0) return false;
        if (digits[0] == 0) return false;
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] != 0)
            {
                return true;
            }
        }
        return false;
    }

    public static bool IsArmstrongNumber(int number, int[] digits)
    {
        double sum = 0;
        int power = digits.Length;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += Math.Pow(digits[i], power);
        }
        return (int)sum == Math.Abs(number);
    }

    public static void FindLargestAndSecondLargest(int[] digits, out int largest, out int secondLargest)
    {
        largest = Int32.MinValue;
        secondLargest = Int32.MinValue;
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }
    }

    public static void FindSmallestAndSecondSmallest(int[] digits, out int smallest, out int secondSmallest)
    {
        smallest = Int32.MaxValue;
        secondSmallest = Int32.MaxValue;
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] < smallest)
            {
                secondSmallest = smallest;
                smallest = digits[i];
            }
            else if (digits[i] < secondSmallest && digits[i] != smallest)
            {
                secondSmallest = digits[i];
            }
        }
    }

    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += digits[i];
        }
        return sum;
    }

    public static double SumOfSquaresOfDigits(int[] digits)
    {
        double sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += Math.Pow(digits[i], 2);
        }
        return sum;
    }

    public static bool IsHarshadNumber(int number, int[] digits)
    {
        int sum = SumOfDigits(digits);
        if (sum == 0) return false;
        return Math.Abs(number) % sum == 0;
    }

    public static int[,] GetDigitFrequency(int[] digits)
    {
        int[] counts = new int[10];
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] >= 0 && digits[i] <= 9)
            {
                counts[digits[i]]++;
            }
        }

        int uniqueCount = 0;
        for (int i = 0; i < 10; i++)
        {
            if (counts[i] > 0)
            {
                uniqueCount++;
            }
        }

        int[,] freq = new int[uniqueCount, 2];
        int index = 0;
        for (int i = 0; i < 10; i++)
        {
            if (counts[i] > 0)
            {
                freq[index, 0] = i;
                freq[index, 1] = counts[i];
                index++;
            }
        }
        return freq;
    }

    public static int[] ReverseArray(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            reversed[i] = digits[digits.Length - 1 - i];
        }
        return reversed;
    }

    public static bool AreArraysEqual(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length) return false;
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i]) return false;
        }
        return true;
    }

    public static bool IsPalindrome(int[] digits)
    {
        int[] reversed = ReverseArray(digits);
        return AreArraysEqual(digits, reversed);
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    public static bool IsNeonNumber(int number)
    {
        int square = number * number;
        int[] digits = StoreDigits(square);
        return SumOfDigits(digits) == number;
    }

    public static bool IsSpyNumber(int number)
    {
        int[] digits = StoreDigits(number);
        int sum = 0;
        int product = 1;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += digits[i];
            product *= digits[i];
        }
        return sum == product;
    }

    public static bool IsAutomorphicNumber(int number)
    {
        long square = (long)number * number;
        string numStr = Math.Abs(number).ToString();
        string squareStr = square.ToString();
        return squareStr.EndsWith(numStr);
    }

    public static bool IsBuzzNumber(int number)
    {
        int absNum = Math.Abs(number);
        return absNum % 7 == 0 || absNum % 10 == 7;
    }

    public static int[] FindFactors(int number)
    {
        int absNum = Math.Abs(number);
        int count = 0;
        for (int i = 1; i <= absNum; i++)
        {
            if (absNum % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= absNum; i++)
        {
            if (absNum % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }
        return factors;
    }

    public static int FindGreatestFactor(int[] factors)
    {
        if (factors.Length == 0) return 0;
        int max = factors[0];
        for (int i = 1; i < factors.Length; i++)
        {
            if (factors[i] > max)
            {
                max = factors[i];
            }
        }
        return max;
    }

    public static int FindSumOfFactors(int[] factors)
    {
        int sum = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            sum += factors[i];
        }
        return sum;
    }

    public static long FindProductOfFactors(int[] factors)
    {
        long product = 1;
        for (int i = 0; i < factors.Length; i++)
        {
            product *= factors[i];
        }
        return product;
    }

    public static double FindProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;
        for (int i = 0; i < factors.Length; i++)
        {
            product *= Math.Pow(factors[i], 3);
        }
        return product;
    }

    public static bool IsPerfectNumber(int number)
    {
        if (number <= 0) return false;
        int[] factors = FindFactors(number);
        int sum = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            if (factors[i] != number)
            {
                sum += factors[i];
            }
        }
        return sum == number;
    }

    public static bool IsAbundantNumber(int number)
    {
        if (number <= 0) return false;
        int[] factors = FindFactors(number);
        int sum = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            if (factors[i] != number)
            {
                sum += factors[i];
            }
        }
        return sum > number;
    }

    public static bool IsDeficientNumber(int number)
    {
        if (number <= 0) return false;
        int[] factors = FindFactors(number);
        int sum = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            if (factors[i] != number)
            {
                sum += factors[i];
            }
        }
        return sum < number;
    }

    public static bool IsStrongNumber(int number)
    {
        if (number <= 0) return false;
        int[] digits = StoreDigits(number);
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += Factorial(digits[i]);
        }
        return sum == number;
    }

    public static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }
}
