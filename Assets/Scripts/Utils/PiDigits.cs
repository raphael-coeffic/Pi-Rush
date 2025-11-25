using UnityEngine;
using System.Text;

public static class PiDigits
{
    private static readonly int[] digits =
    {
        1,4,1,5,9,2,6,5,3,5,
        8,9,7,9,3,2,3,8,4,6
    };

    public static int GetDigit(int index)
    {
        if (index < 0 || index >= digits.Length)
            return 0;

        return digits[index];
    }

    public static string GetPrefix(int count)
    {
        if (count < 0) count = 0;
        if (count > digits.Length) count = digits.Length;

        StringBuilder sb = new StringBuilder("3");

        if (count > 0)
        {
            sb.Append('.');
            for (int i = 0; i < count; i++)
            {
                sb.Append(digits[i]);
            }
        }

        return sb.ToString();
    }

    public static int MaxDigits => digits.Length;
}
