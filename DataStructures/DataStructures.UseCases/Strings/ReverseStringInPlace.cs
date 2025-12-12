using System;
using System.Text;

namespace DataStructures.UseCases.Strings
{
    public class ReverseStringInPlace : IUseCase<string>
    {
        private readonly string _str;

        public ReverseStringInPlace(string str)
        {
            _str = str;
        }

        public string Execute()
        {
            if (!string.IsNullOrEmpty(_str))
            {
                var chars = _str.ToCharArray();
                int left = 0;
                int right = chars.Length - 1;

                while (left < right)
                {
                    // Swap
                    var temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;
                    // Increment pointer
                    left++;
                    // Decrement pointer
                    right--;
                }

                return new string(chars);
            }

            return string.Empty;
        }
    }
}