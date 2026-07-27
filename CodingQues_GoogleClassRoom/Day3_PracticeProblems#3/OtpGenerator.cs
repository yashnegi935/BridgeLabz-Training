namespace CalculatorProblems;

public class OtpGenerator
{
    public static void Run()
    {
        int[] otps = new int[10];
        for (int i = 0; i < otps.Length; i++)
        {
            otps[i] = GenerateOtp();
        }

        Console.WriteLine("Generated 6-digit OTPs:");
        for (int i = 0; i < otps.Length; i++)
        {
            Console.WriteLine($"OTP {i + 1}: {otps[i]}");
        }

        bool areUnique = ValidateUniqueness(otps);
        Console.WriteLine($"All OTPs are unique: {areUnique}");
    }

    public static int GenerateOtp()
    {
        Random random = new Random();
        return (int)(random.NextDouble() * 900000) + 100000;
    }

    public static bool ValidateUniqueness(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
