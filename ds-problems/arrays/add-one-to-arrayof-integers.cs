namespace ds_problems.arrays
{
    // [5,8,9] -> 1 -> [5, 9, 0]
    // [9,9,9] -> 1 -> [1, 0, 0, 0]
    public class AddOneToArray
    {
        public int[] AddNumberToArray(int[] digits)
        {
            int carry = 1;
            for (int i = digits.Length - 1; i >= 0 && carry > 0; i--)
            {
                int sum = digits[i] + carry;
                digits[i] = sum % 10;
                carry = sum / 10;
            }

            if (carry == 0 || digits.Length < 1)
                return digits;

            int[] newDigits = new int[digits.Length + 1];
            newDigits[0] = carry;
            for (int i = 1; i < newDigits.Length; i++)
            {
                newDigits[i] = digits[i - 1];
            }

            return newDigits;
        }
    }
}